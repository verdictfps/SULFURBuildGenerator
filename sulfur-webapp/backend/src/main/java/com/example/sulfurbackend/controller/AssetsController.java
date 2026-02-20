package com.example.sulfurbackend.controller;

import org.springframework.core.io.ClassPathResource;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

@RestController
public class AssetsController {

    private static final String DATA_ROOT = "data/JSON";

    @GetMapping("/api/oils")
    public ResponseEntity<List<String>> listOils() throws IOException {
        return ResponseEntity.ok(listFilesUnder("Oils"));
    }

    @GetMapping("/api/scrolls")
    public ResponseEntity<List<String>> listScrolls() throws IOException {
        return ResponseEntity.ok(listFilesUnder("Scrolls"));
    }

    @GetMapping("/api/list")
    public ResponseEntity<List<String>> list(@RequestParam(required = false, defaultValue = "") String path) throws IOException {
        if (path.contains("..")) {
            return ResponseEntity.badRequest().build();
        }
        String sub = path == null || path.isBlank() ? "" : path.replace("\\", "/");
        return ResponseEntity.ok(listFilesUnder(sub));
    }

    @GetMapping(value = "/api/file", produces = MediaType.APPLICATION_JSON_VALUE)
    public ResponseEntity<String> getFile(@RequestParam String path) throws IOException {
        // sanitize path
        if (path.contains("..")) {
            return ResponseEntity.badRequest().body("{}");
        }

        // Try multiple filesystem locations first (workspace copy, original project)
        Path fsPath1 = Paths.get("./sulfur-webapp/backend/src/main/resources/" + DATA_ROOT + "/" + path);
        Path fsPath2 = Paths.get("./SULFURBuildGenerator/JSON/" + path);

        if (Files.exists(fsPath1)) {
            return ResponseEntity.ok().contentType(MediaType.APPLICATION_JSON).body(Files.readString(fsPath1));
        }
        if (Files.exists(fsPath2)) {
            return ResponseEntity.ok().contentType(MediaType.APPLICATION_JSON).body(Files.readString(fsPath2));
        }

        // Try classpath
        ClassPathResource res = new ClassPathResource("data/JSON/" + path);
        if (res.exists()) {
            var bytes = Files.readAllBytes(res.getFile().toPath());
            return ResponseEntity.ok().contentType(MediaType.APPLICATION_JSON).body(new String(bytes));
        }

        return ResponseEntity.notFound().build();
    }

    private List<String> listFilesUnder(String subfolder) throws IOException {
        // Normalize
        String sub = (subfolder == null || subfolder.isBlank()) ? "" : subfolder.replace("\\", "/");

        // Try multiple filesystem locations first
        Path fsPath1 = Paths.get("./sulfur-webapp/backend/src/main/resources/" + DATA_ROOT + (sub.isEmpty() ? "" : "/" + sub));
        Path fsPath2 = Paths.get("./SULFURBuildGenerator/JSON/" + (sub.isEmpty() ? "" : sub));

        if (Files.exists(fsPath1) && Files.isDirectory(fsPath1)) {
            return Files.list(fsPath1)
                    .map(p -> p.getFileName().toString())
                    .collect(Collectors.toList());
        }
        if (Files.exists(fsPath2) && Files.isDirectory(fsPath2)) {
            return Files.list(fsPath2)
                    .map(p -> p.getFileName().toString())
                    .collect(Collectors.toList());
        }

        // Try classpath
        ClassPathResource res = new ClassPathResource((sub.isEmpty() ? "data/JSON" : "data/JSON/" + sub));
        if (res.exists()) {
            var file = res.getFile();
            if (file.isDirectory()) {
                return Arrays.stream(file.list())
                        .collect(Collectors.toList());
            }
        }

        return List.of();
    }
}
