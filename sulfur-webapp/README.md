# Sulfur Webapp

This repository is a new Java + React webapp skeleton to host the SULFUR build generator data and UI.

Layout
- `backend/` - Spring Boot application (Java 21, Maven)
- `frontend/` - React app (Create React App)

Run locally
1. Start backend:
   - `cd sulfur-webapp/backend && mvn spring-boot:run`
2. Start frontend (in another terminal):
   - `cd sulfur-webapp/frontend && npm install && npm start`

Or with Docker:
- `docker build -t sulfur-webapp ./sulfur-webapp && docker run -p 8080:8080 sulfur-webapp`

Deploy
- CI provided via GitHub Actions (.github/workflows/ci.yml)

Notes
- This is a minimal scaffold. I created a simple `/api/oils` endpoint that reads from `backend/src/main/resources/data/oils.json` for demonstration. Add more endpoints or port the C# logic as needed.
