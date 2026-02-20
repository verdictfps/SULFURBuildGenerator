# Build frontend
FROM node:18 AS frontend-build
WORKDIR /app/frontend
COPY frontend/package.json frontend/package-lock.json* ./
RUN npm ci --silent || npm install
COPY frontend/ ./
RUN npm run build

# Build backend
FROM maven:3.8.8-eclipse-temurin-21 AS backend-build
WORKDIR /app/backend
COPY backend/pom.xml ./
RUN mvn -B -f pom.xml dependency:go-offline
COPY backend/src ./src
RUN mvn -B -f pom.xml package -DskipTests

# Final image
FROM eclipse-temurin:21-jre
WORKDIR /app
COPY --from=backend-build /app/backend/target/sulfur-backend-0.0.1-SNAPSHOT.jar ./app.jar
COPY --from=frontend-build /app/frontend/build ./public
EXPOSE 8080
ENTRYPOINT ["java","-jar","/app/app.jar"]
