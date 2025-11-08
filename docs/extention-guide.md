# Extending the Terraform Deployment Model

This guide shows how to extend the base Terraform deployment model with cloud-specific resource processors.

## Architecture Overview

The current implementation provides the **framework** for Terraform deployment:

- Environment management
- Pipeline integration
- File generation
- Customization hooks

To make it fully functional, you need to add **resource processors** that convert Aspire resources into cloud-specific Terraform resources.

## Implementation Approaches

### Approach 1: Annotation-Based Processors (Recommended)

Add processors that detect resource types and generate appropriate infrastructure.

```csharp
// Create a processor for AWS ECS
public class AwsEcsResourceProcessor
{
    public void Process(TerraformStack stack, IResource resource, TerraformEnvironmentResource environment)
    {
        if (resource is ProjectResource projectResource)
        {
            ProcessProjectAsEcsTask(stack, projectResource);
        }
        else if (resource is ContainerResource containerResource)
        {
            ProcessContainerAsEcsTask(stack, containerResource);
        }
    }

    private void ProcessProjectAsEcsTask(TerraformStack stack, ProjectResource project)
    {
        // Using your EmmittJ.Terraform.Sdk:

        // 1. Create ECR repository
        var repository = new EcrRepository($"{project.Name}-repo")
        {
            Name = project.Name,
            ImageScanningConfiguration = new { ScanOnPush = true },
            Tags = { ["aspire-resource"] = project.Name }
        };
        stack.AddResource(repository);

        // 2. Create ECS Task Definition
        var taskDefinition = new EcsTaskDefinition($"{project.Name}-task")
        {
            Family = project.Name,
            NetworkMode = "awsvpc",
            RequiresCompatibilities = ["FARGATE"],
            Cpu = "256",
            Memory = "512",
            ContainerDefinitions = JsonSerializer.Serialize(new[]
            {
                new
                {
                    name = project.Name,
                    image = $"${{aws_ecr_repository.{repository.LogicalId}.repository_url}}:latest",
                    portMappings = GetPortMappings(project),
                    environment = GetEnvironmentVariables(project),
                    logConfiguration = GetLogConfiguration(project)
                }
            })
        };
        stack.AddResource(taskDefinition);

        // 3. Create ECS Service
        if (project.TryGetEndpoints(out var endpoints) && endpoints.Any(e => e.IsExternal))
        {
            // Create ALB, Target Group, Service with load balancer
            CreateServiceWithLoadBalancer(stack, project, taskDefinition);
        }
        else
        {
            // Create service without load balancer
            CreateServiceWithoutLoadBalancer(stack, project, taskDefinition);
        }
    }
}
```

### Approach 2: Provider-Specific Extensions

Create extension methods for specific cloud providers.

```csharp
public static class AwsTerraformExtensions
{
    public static IResourceBuilder<TerraformEnvironmentResource> ForAws(
        this IResourceBuilder<TerraformEnvironmentResource> builder,
        string region = "us-west-2")
    {
        return builder.WithProperties(env =>
        {
            // Add AWS provider configuration
            env.BackendConfig["region"] = region;
        });
    }

    public static IResourceBuilder<T> AsEcsTask<T>(
        this IResourceBuilder<T> builder,
        Action<EcsTaskConfiguration>? configure = null)
        where T : IResource
    {
        var config = new EcsTaskConfiguration();
        configure?.Invoke(config);

        return builder.WithTerraformCustomization((stack, resource) =>
        {
            var processor = new AwsEcsResourceProcessor();
            processor.Process(stack, resource, config);
        });
    }
}

// Usage:
var awsEnv = builder.AddTerraformEnvironment("aws")
    .ForAws("us-east-1");

var api = builder.AddProject<Projects.Api>("api")
    .AsEcsTask(config =>
    {
        config.Cpu = "512";
        config.Memory = "1024";
        config.DesiredCount = 3;
    });
```

### Approach 3: Convention-Based Processing

Automatically detect cloud provider from backend and process accordingly.

```csharp
// In TerraformPublishingContext.ProcessResourceByTypeAsync
private async Task ProcessResourceByTypeAsync(IResource resource)
{
    // Detect provider from backend type
    var processor = _environment.BackendType switch
    {
        "s3" => new AwsResourceProcessor(),
        "azurerm" => new AzureResourceProcessor(),
        "gcs" => new GcpResourceProcessor(),
        _ => new GenericResourceProcessor()
    };

    await processor.ProcessResourceAsync(resource, _stack, _executionContext, _cancellationToken);
}
```

## Example: Complete AWS ECS Processor

```csharp
// File: AwsEcsResourceProcessor.cs
using EmmittJ.Terraform.Sdk;
using EmmittJ.Terraform.Sdk.Providers.Aws;
using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Aspire.Hosting.Terraform.Processors;

public class AwsEcsResourceProcessor
{
    private readonly TerraformStack _stack;

    public AwsEcsResourceProcessor(TerraformStack stack)
    {
        _stack = stack;
    }

    public void ProcessResource(IResource resource)
    {
        switch (resource)
        {
            case ProjectResource project:
                ProcessProject(project);
                break;
            case ContainerResource container:
                ProcessContainer(container);
                break;
            case RedisResource redis:
                ProcessRedis(redis);
                break;
            case PostgresServerResource postgres:
                ProcessPostgres(postgres);
                break;
        }
    }

    private void ProcessProject(ProjectResource project)
    {
        // ECR Repository
        var repo = new EcrRepository($"{project.Name}-repo")
        {
            Name = project.Name.ToLowerInvariant()
        };
        _stack.AddResource(repo);

        // CloudWatch Log Group
        var logGroup = new CloudwatchLogGroup($"{project.Name}-logs")
        {
            Name = $"/ecs/{project.Name}",
            RetentionInDays = 7
        };
        _stack.AddResource(logGroup);

        // Task Execution Role
        var executionRole = CreateTaskExecutionRole(project);
        _stack.AddResource(executionRole);

        // Task Role
        var taskRole = CreateTaskRole(project);
        _stack.AddResource(taskRole);

        // Security Group
        var securityGroup = CreateSecurityGroup(project);
        _stack.AddResource(securityGroup);

        // Task Definition
        var taskDef = CreateTaskDefinition(project, repo, logGroup, executionRole, taskRole);
        _stack.AddResource(taskDef);

        // ECS Service (with or without ALB)
        if (HasExternalEndpoints(project))
        {
            var alb = CreateApplicationLoadBalancer(project, securityGroup);
            _stack.AddResource(alb);

            var targetGroup = CreateTargetGroup(project, alb);
            _stack.AddResource(targetGroup);

            var listener = CreateListener(alb, targetGroup);
            _stack.AddResource(listener);

            var service = CreateServiceWithLoadBalancer(project, taskDef, targetGroup, securityGroup);
            _stack.AddResource(service);
        }
        else
        {
            var service = CreateService(project, taskDef, securityGroup);
            _stack.AddResource(service);
        }
    }

    private void ProcessRedis(RedisResource redis)
    {
        var subnetGroup = new ElasticacheSubnetGroup($"{redis.Name}-subnet-group")
        {
            Name = $"{redis.Name}-subnet-group",
            SubnetIds = ["${var.private_subnet_ids}"] // Reference to variable
        };
        _stack.AddResource(subnetGroup);

        var securityGroup = new SecurityGroup($"{redis.Name}-sg")
        {
            Name = $"{redis.Name}-sg",
            VpcId = "${var.vpc_id}",
            Ingress = new[]
            {
                new
                {
                    from_port = 6379,
                    to_port = 6379,
                    protocol = "tcp",
                    cidr_blocks = new[] { "10.0.0.0/16" }
                }
            }
        };
        _stack.AddResource(securityGroup);

        var cluster = new ElasticacheCluster($"{redis.Name}-cluster")
        {
            ClusterId = redis.Name.ToLowerInvariant(),
            Engine = "redis",
            NodeType = "cache.t3.micro",
            NumCacheNodes = 1,
            ParameterGroupName = "default.redis7",
            Port = 6379,
            SubnetGroupName = subnetGroup.Reference("name"),
            SecurityGroupIds = [securityGroup.Reference("id")]
        };
        _stack.AddResource(cluster);

        // Output the connection string
        _stack.AddOutput($"{redis.Name}-endpoint", new
        {
            value = cluster.Reference("cache_nodes[0].address")
        });
    }

    private void ProcessPostgres(PostgresServerResource postgres)
    {
        // Similar implementation for RDS PostgreSQL
        // - DB Subnet Group
        // - Security Group
        // - RDS Instance
        // - Secrets Manager for credentials
        // - Outputs for connection info
    }

    // Helper methods...
    private IamRole CreateTaskExecutionRole(ProjectResource project) { /* ... */ }
    private IamRole CreateTaskRole(ProjectResource project) { /* ... */ }
    private SecurityGroup CreateSecurityGroup(ProjectResource project) { /* ... */ }
    private EcsTaskDefinition CreateTaskDefinition(...) { /* ... */ }
    private bool HasExternalEndpoints(IResource resource) { /* ... */ }
    // ... more helpers
}
```

## Integration Points

### 1. Update TerraformPublishingContext

```csharp
// In TerraformPublishingContext.ProcessResourceAsync
private async Task ProcessResourceAsync(TerraformResource terraformResource)
{
    _logger.LogInformation("Processing resource: {ResourceName}", terraformResource.TargetResource.Name);

    var resource = terraformResource.TargetResource;

    // Apply any TerraformCustomizationAnnotation customizations first
    if (resource.TryGetAnnotationsOfType<TerraformCustomizationAnnotation>(out var annotations))
    {
        foreach (var annotation in annotations)
        {
            annotation.Configure(_stack, resource);
        }
    }

    // NEW: Auto-process based on resource type
    var processor = GetResourceProcessor();
    processor.ProcessResource(resource);

    // Apply TerraformCustomizationAnnotation overrides last
    if (resource.TryGetAnnotationsOfType<TerraformCustomizationAnnotation>(out var customizations))
    {
        foreach (var customization in customizations)
        {
            customization.Configure(_stack, resource);
        }
    }
}

private IResourceProcessor GetResourceProcessor()
{
    return _environment.BackendType switch
    {
        "s3" => new AwsEcsResourceProcessor(_stack),
        "azurerm" => new AzureContainerInstanceProcessor(_stack),
        "gcs" => new GcpCloudRunProcessor(_stack),
        _ => new NoOpResourceProcessor()
    };
}
```

### 2. Add Provider Configuration

```csharp
// In TerraformPublishingContext.ConfigureBackend
private void ConfigureBackend()
{
    _logger.LogInformation("Configuring Terraform backend: {BackendType}", _environment.BackendType);

    // Add provider based on backend type
    switch (_environment.BackendType)
    {
        case "s3":
            AddAwsProvider();
            break;
        case "azurerm":
            AddAzureProvider();
            break;
        case "gcs":
            AddGcpProvider();
            break;
    }

    // Configure backend
    _stack.AddBackend(_environment.BackendType, _environment.BackendConfig);
}

private void AddAwsProvider()
{
    var region = _environment.BackendConfig.TryGetValue("region", out var r)
        ? r.ToString()
        : "us-west-2";

    _stack.AddProvider("aws", new
    {
        region = region,
        default_tags = new
        {
            tags = new
            {
                ManagedBy = "Aspire",
                Environment = _environment.WorkspaceName ?? "default"
            }
        }
    });
}
```

## File Organization

Recommended structure for processors:

```
EmmittJ.Aspire.Hosting.Terraform/
├── Core/
│   ├── TerraformEnvironmentResource.cs
│   ├── TerraformPublishingContext.cs
│   └── ...
├── Processors/
│   ├── IResourceProcessor.cs
│   ├── AwsEcsResourceProcessor.cs
│   ├── AzureContainerInstanceProcessor.cs
│   ├── GcpCloudRunProcessor.cs
│   └── NoOpResourceProcessor.cs
├── Extensions/
│   ├── AwsTerraformExtensions.cs
│   ├── AzureTerraformExtensions.cs
│   └── GcpTerraformExtensions.cs
└── Configuration/
    ├── EcsTaskConfiguration.cs
    ├── AciConfiguration.cs
    └── CloudRunConfiguration.cs
```

## Next Steps

1. **Choose Your Approach**: Annotation-based, provider-specific, or convention-based
2. **Implement Processors**: Start with one cloud provider
3. **Test with Real Resources**: Deploy actual Aspire apps
4. **Add More Resources**: Expand to databases, caches, queues, etc.
5. **Optimize**: Add variable extraction, module organization, etc.

## Example Package Structure

Consider creating separate packages:

- `EmmittJ.Aspire.Hosting.Terraform` - Core (current implementation)
- `EmmittJ.Aspire.Hosting.Terraform.Aws` - AWS processors
- `EmmittJ.Aspire.Hosting.Terraform.Azure` - Azure processors
- `EmmittJ.Aspire.Hosting.Terraform.Gcp` - GCP processors

This allows users to install only what they need!
