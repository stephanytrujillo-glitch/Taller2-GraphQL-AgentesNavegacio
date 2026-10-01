package com.mycompany.sistemaagentesinteligentes.exception;

import graphql.GraphQLError;
import graphql.GraphqlErrorBuilder;
import graphql.schema.DataFetchingEnvironment;
import org.springframework.graphql.execution.DataFetcherExceptionResolverAdapter;
import org.springframework.graphql.execution.ErrorType;
import org.springframework.stereotype.Component;

/**
 * Convierte las excepciones del servidor (validaciones del modelo, ID repetido,
 * agente no encontrado...) en errores GraphQL con un mensaje legible para el cliente C#.
 * Sin esta clase Spring solo devolveria "INTERNAL_ERROR".
 */
@Component
public class ManejadorErroresGraphQL extends DataFetcherExceptionResolverAdapter {

    @Override
    protected GraphQLError resolveToSingleError(Throwable ex, DataFetchingEnvironment env) {
        ErrorType tipo = (ex instanceof AgenteNoEncontradoException) ? ErrorType.NOT_FOUND : ErrorType.BAD_REQUEST;
        return GraphqlErrorBuilder.newError(env)
                .errorType(tipo)
                .message(ex.getMessage() != null ? ex.getMessage() : "Error inesperado en el servidor")
                .build();
    }
}
