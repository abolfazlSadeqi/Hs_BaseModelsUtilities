# Hs_BaseModelsUtilities

**Hs_BaseModelsUtilities** is a comprehensive, modular, and reusable C# utility library designed to serve as a foundation for enterprise-level applications.  
It provides **standardized configurations, constants, enums, domain models, interfaces, custom exceptions, and implementations of common design patterns** to accelerate development, ensure maintainability, and promote code consistency.

This library is designed to be **highly extensible**, making it suitable for projects that require:
- Clean architecture and Domain-Driven Design (DDD) principles  
- Advanced observability, logging, and telemetry  
- Messaging and event-driven systems  
- Security and authentication frameworks  
- Utility services for data handling, file storage, serialization, and encryption  

---

## Core Modules

The library is organized into several **core modules**, each covering a specific domain of functionality.

### 1. Configurations
Provides strongly-typed settings for applications, databases, messaging, observability, security, and other utilities.  
**Purpose:** Centralized configuration management to ensure consistency across applications.

**Submodules:**

- **Application Settings**
  - `ApiVersioningSettings`
  - `ExternalServiceSettings`
  - `LocalizationSettings`
  - `SwaggerSettings`

- **Database Settings**
  - `SqlDatabaseSettings`, `MongoDbSettings`, `RedisSettings`, `ElasticSearchSettings`

- **Message Brokers**
  - `KafkaSettings`

- **Observability**
  - `TelemetrySettings`

- **Others**
  - `FeatureFlagSettings`, `FileStorageSettings`, `HealthCheckSettings`, `PerformanceSettings`, `RolePermissionSettings`, `SmtpSettings`, `WorkflowSettings`

- **Security**
  - `AppSettings`, `AuthenticationSettings`, `CorsSettings`, `JwtSettings`, `MessagingSettings`, `PasswordPolicySettings`, `RateLimitSettings`

---

### 2. Constants
Contains application-wide constants including:

- API, Cache, HTTP headers, Methods, Status codes  
- File paths, Extensions, Colors, Date formats  
- Security, Threading, Logging, Pagination, Themes, Workflow  

**Purpose:** Prevent magic strings/numbers and standardize values across the project.

---

### 3. Enums
Highly categorized enums for type safety and clarity:

- **Base:** `StatusType`, `YesNo`, `SortDirection`, `Gender`, `LanguageCode`  
- **Business:** `UserRole`, `UserStatus`  
- **Infrastructure:** `DatabaseType`, `CloudProvider`, `EnvironmentType`, `FileStorageType`, etc.  
- **Jobs:** `JobPriority`, `JobStatus`, `OptInStatus`, `ScheduleType`  
- **Media:** `ImageFormat`, `MediaType`, `VideoQuality`  
- **Messaging:** `ApiProtocol`, `MessageBrokerType`, `MessageFormat`, `QueueType`, `MessageStatus`  
- **Monitoring:** `LogCategory`, `LoggerProvider`, `LogLevel`, `MonitoringProvider`  
- **Notifications:** `NotificationType`, `NotificationTemplate`  
- **Reports:** `DocumentType`, `FileCategory`, `ReportCategory`, `ReportFormat`  
- **Security:** `AuthProvider`, `JwtAlgorithm`, `FileAccessLevel`, `EncryptionAlgorithm`, `RetryPolicy`  
- **UI/UX:** `ButtonStyle`, `InputType`, `LayoutType`, `ThemeType`  
- **Workflow:** `FeatureToggleType`, `WorkflowStatus`  

---

### 4. Design Patterns
Implements core design patterns to promote reusable and maintainable architecture:

- **Creational Patterns:** Singleton, Factory, Builder  
- **Structural Patterns:** Adapter, Composite, Decorator, Facade, Proxy  
- **Behavioral Patterns:** Strategy, Observer, Command, Template Method, Chain of Responsibility, State, Visitor, Specification, Mediator  

**Purpose:** Provide base classes and interfaces that simplify pattern implementation across projects.

---

### 5. Exceptions
Custom exceptions for better error handling and clarity:

- **Auth & Security:** `AccessDeniedException`, `AccountLockedException`, `ExpiredTokenException`, `InvalidTokenException`  
- **Database:** `DatabaseUnavailableException`, `DataConflictException`, `RecordNotFoundException`  
- **Feature Logic:** `DeprecatedMethodException`, `NotImplementedFeatureException`  
- **File Storage:** `FileAccessDeniedException`, `FileNotFoundException`, `FileOperationException`  
- **General:** `BadRequestException`, `ConflictException`, `ForbiddenException`, `NotFoundException`, `UnauthorizedException`, `ValidationException`, `TimeoutException`, `RateLimitExceededException`  
- **Service & Network:** `DependencyFailedException`, `NetworkException`, `ServiceUnavailableException`  

---

### 6. Interfaces
Interfaces provide contracts for core functionality and services:

- **Core:** `IAggregateRoot`, `IEntity`, `IValueObject`, `IDomainService`, `IApplicationService`  
- **Data Access:** `IRepository`, `IReadRepository`, `IWriteRepository`, `IMongoRepository`, `IRedisCacheRepository`, `IFileRepository`, `IEventSourcingRepository`, `IUnitOfWork`  
- **Messaging:** `IEventPublisher`, `IDomainEventHandler`, `IIntegrationEventHandler`, `IRabbitMqService`, `IMassTransitService`, `IMessageQueueService`  
- **Observability:** `ILoggerService`, `IAuditTrailService`, `IMetricsService`, `ITracingService`, `IHealthCheckService`  
- **Scheduling:** `IJobScheduler`, `IJobQueueService`, `IRetryPolicyService`, `IWorkflowService`  
- **Security:** `IJwtService`, `IPasswordHasher`, `IRolePermissionService`, `IRefreshTokenService`, `IOAuthService`  
- **Services:** `IAuthenticationService`, `IAuthorizationService`, `IEmailService`, `INotificationService`, `ISmsService`, `IExternalApiService`, `IUserDomainService`  
- **Utilities:** `IFileStorageService`, `IJsonSerializer`, `ICompressionService`, `IEncryptionService`, `IDateTimeProvider`, `IRandomProvider`  

---

### 7. Models
Provides reusable domain and common models:

- **Common:** `AuditableResult`, `AuditInfo`, `DataResult`, `ErrorResult`, `PagedResponse`, `Pagination`, `QueryRequest`, `ServiceResponse`, `UserContext`, `TenantContext`, `ValidationError`  
- **Domain Base:** `AggregateRoot`, `BaseEntity`  
- **Domain Events:** `CreatedEvent`, `UpdatedEvent`, `DeletedEvent`, `DomainEventBase`  
- **Domain Value Objects:** `Address`, `Email`, `Money`, `Percentage`, `PhoneNumber`, `ValueObject`  

---

## Installation

```bash
# Install via NuGet or add project reference
dotnet add package Hs_BaseModelsUtilities
