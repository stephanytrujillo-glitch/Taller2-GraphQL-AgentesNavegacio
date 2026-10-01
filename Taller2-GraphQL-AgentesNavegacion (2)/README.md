# Segundo Taller 2026B – Diseño de Soluciones
## Sistema de Agentes Inteligentes – CRUD de **AgenteNavegacion** con Servicios Web GraphQL

**Integrantes:** Juan Acuña, Luis Hernández, Stephany Trujillo

Aplicación distribuida cliente–servidor basada en el Proyecto 1 (Clase C: `AgenteNavegacion`, que hereda de `AgenteInteligente` e implementa `IAplicable`).

| Componente | Tecnología | Carpeta |
|---|---|---|
| **Servidor** (lógica central + Lista en memoria) | Java 17+ · Spring Boot 3.5 · Spring for GraphQL | `servidor-graphql-java/` |
| **Cliente** (interfaz gráfica, otro lenguaje) | C# · .NET 10 · Windows Forms | `cliente-csharp/` |

### Atributos gestionados

| Atributo | Tipo Java | Origen |
|---|---|---|
| `idAgente` | `int` | AgenteInteligente |
| `nombre` | `String` | AgenteInteligente |
| `nivelAutonomia` | `double` (0-100) | AgenteInteligente |
| `estadoOperativo` | `String` (ACTIVO / INACTIVO / MANTENIMIENTO) | AgenteInteligente |
| `nivelConfianza` | `double` (0-100) | AgenteInteligente |
| `origen`, `destino` | `String` | AgenteNavegacion |
| `precisionGPS` | `double` (0-100) | AgenteNavegacion |
| `fechaUltimaCalibracion` | **`LocalDateTime`** | AgenteNavegacion (**nuevo en el Taller 2**) |
| `rendimiento` *(solo lectura)* | `double` = `calcularRendimiento()` | Polimorfismo del Proyecto 1 |

---

## Estructura

```text
Taller2-GraphQL-AgentesNavegacion/
├── servidor-graphql-java/
│   ├── pom.xml
│   ├── consultas-ejemplo.graphql
│   └── src/main/
│       ├── java/com/mycompany/sistemaagentesinteligentes/
│       │   ├── SistemaAgentesGraphQLApplication.java
│       │   ├── model/        AgenteInteligente, AgenteNavegacion, IAplicable, AgenteNavegacionInput
│       │   ├── services/     ServicioAgentesNavegacion (List en memoria + CRUD + filtros)
│       │   ├── controller/   AgenteNavegacionController (Queries y Mutations GraphQL)
│       │   └── exception/    AgenteNoEncontradoException, ManejadorErroresGraphQL
│       └── resources/
│           ├── application.properties
│           └── graphql/schema.graphqls
└── cliente-csharp/
    ├── ClienteAgentesGraphQL.sln
    └── ClienteAgentesGraphQL/
        ├── Model/       AgenteNavegacion, AgenteNavegacionInput
        ├── Services/    GraphQLService (comunicación HTTP / GraphQL)
        ├── GUI/         GUIPrincipal, GUIAdicionarNavegacion, GUIConsultarNavegacion,
        │                GUIListarNavegacion, GUIEditarNavegacion, GUIEliminarNavegacion, GUIAcercaDe
        ├── AppInfo.cs   Nombre, versión e integrantes
        └── servidor.txt URL del servidor GraphQL
```

---

## 1. Ejecutar el servidor (Java)

Requisitos: **JDK 17 o superior** (sirve el JDK 21 de NetBeans) e Internet la primera vez.

- **NetBeans / IntelliJ:** abrir `servidor-graphql-java` como proyecto Maven y ejecutar `SistemaAgentesGraphQLApplication`.
- **Consola (Windows):**
  ```powershell
  cd servidor-graphql-java
  .\mvnw.cmd spring-boot:run
  ```

Queda en `http://localhost:8081/graphql`. Consola de pruebas: `http://localhost:8081/graphiql` (use `consultas-ejemplo.graphql`).
Arranca con 3 agentes de prueba (IDs 1, 2 y 3).

## 2. Ejecutar el cliente (C#)

Requisitos: **Visual Studio 2026** (o 2022 con .NET 10 instalado) con *Desarrollo de escritorio de .NET*.

1. Abrir `cliente-csharp/ClienteAgentesGraphQL.sln`.
2. Con el servidor encendido, presionar **F5**.
3. Opcional: *Archivo → Probar conexión con el servidor*.

No usa paquetes NuGet: la comunicación GraphQL se hace con `HttpClient` + `System.Text.Json`.

## 3. Varios clientes en red

El servidor escucha en `0.0.0.0:8081`. En cada equipo cliente editar `servidor.txt` (junto al `.exe`, en `bin/Debug/net10.0-windows/`):

```text
http://IP_DEL_SERVIDOR:8081/graphql
```

---

## API GraphQL

| Caso de uso | Operación | Tipo |
|---|---|---|
| Listar todos (variante 1) | `agentesNavegacion` | Query |
| Listar por filtro (variante 2, **filtrado en servidor**) | `agentesNavegacionPorFiltro(nombre, estadoOperativo)` | Query |
| Consultar uno | `agenteNavegacionPorId(idAgente)` | Query |
| Adicionar | `crearAgenteNavegacion(input)` | Mutation |
| Actualizar | `actualizarAgenteNavegacion(input)` | Mutation |
| Eliminar | `eliminarAgenteNavegacion(idAgente)` | Mutation |

---

## Cumplimiento de la rúbrica

| Criterio | Cómo se cumple |
|---|---|
| **Arquitectura** | Servidor: `model`, `services`, `controller`, `exception`. Cliente: `GUI`, `Model`, `Services`. Las ventanas solo hacen tareas de interfaz; la comunicación está en `GraphQLService`. |
| **GraphQL + otro lenguaje + Lista** | Servidor Java con Spring for GraphQL; cliente C#; agentes en un `ArrayList` en memoria. |
| **Insertar (20%)** | `GUIAdicionarNavegacion` → `crearAgenteNavegacion`. El servidor valida rangos, estado, ID único y fecha. |
| **Eliminar (20%)** | `GUIEliminarNavegacion`: busca por ID → muestra **toda** la información → confirma → elimina. |
| **Listar con parámetros (25%)** | `GUIListarNavegacion`: grilla con todos los agentes + filtros **nombre** y **estado operativo** resueltos en el servidor. |
| **Actualizar (20%)** | `GUIEditarNavegacion`: busca por ID, muestra **toda** la información en campos editables, permite cambiar uno o varios atributos. |
| **Consultar (15%)** | `GUIConsultarNavegacion`: un solo agente a partir del ID, con todos sus atributos y su rendimiento. |
| Una ventana por caso de uso | 5 ventanas de CRUD independientes + principal + Acerca de. |
| Menú y “Ayuda → Acerca de…” | Menús *Archivo*, *Agente de Navegación* y *Ayuda*; integrantes y versión en `GUIAcercaDe`. |
