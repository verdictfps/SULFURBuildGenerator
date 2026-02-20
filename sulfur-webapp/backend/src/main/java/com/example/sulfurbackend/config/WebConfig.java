package com.example.sulfurbackend.config;

import org.springframework.context.annotation.Configuration;
import org.springframework.web.servlet.config.annotation.ResourceHandlerRegistry;
import org.springframework.web.servlet.config.annotation.WebMvcConfigurer;

@Configuration
public class WebConfig implements WebMvcConfigurer {
    @Override
    public void addResourceHandlers(ResourceHandlerRegistry registry) {
        // Serve frontend build files placed at /app/public inside the final image
        registry.addResourceHandler("/**")
                .addResourceLocations("file:/app/public/", "classpath:/static/", "classpath:/public/");
    }
}
