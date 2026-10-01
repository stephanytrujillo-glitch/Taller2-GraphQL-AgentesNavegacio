package com.mycompany.sistemaagentesinteligentes;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

/**
 * Punto de entrada del servidor GraphQL.
 * Endpoint: http://localhost:8081/graphql  |  Consola de pruebas: http://localhost:8081/graphiql
 */
@SpringBootApplication
public class SistemaAgentesGraphQLApplication {

    public static void main(String[] args) {
        SpringApplication.run(SistemaAgentesGraphQLApplication.class, args);
    }
}
