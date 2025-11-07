using Xunit;

namespace EmmittJ.Terraform.Sdk.Tests;

public class LifecycleTests
{
    [Fact]
    public Task Lifecycle_CreateBeforeDestroy_GeneratesHcl()
    {
        var config = new TerraformStack()
        {
            Name = "test"
        };

        var resource = new TerraformResource("aws_instance", "web");
        resource.WithProperty("ami", "ami-12345678");
        resource.WithProperty("instance_type", "t2.micro");
        resource.Lifecycle = new TerraformLifecycleConfig
        {
            CreateBeforeDestroy = true
        };
        config.Add(resource);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Lifecycle_PreventDestroy_GeneratesHcl()
    {
        var config = new TerraformStack()
        {
            Name = "test"
        };

        var resource = new TerraformResource("aws_s3_bucket", "data");
        resource.WithProperty("bucket", "my-important-data");
        resource.Lifecycle = new TerraformLifecycleConfig
        {
            PreventDestroy = true
        };
        config.Add(resource);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Lifecycle_IgnoreChanges_GeneratesHcl()
    {
        var config = new TerraformStack()
        {
            Name = "test"
        };

        var resource = new TerraformResource("aws_instance", "web");
        resource.WithProperty("ami", "ami-12345678");
        resource.WithProperty("instance_type", "t2.micro");
        resource.Lifecycle = new TerraformLifecycleConfig
        {
            IgnoreChanges = { "tags", "user_data" }
        };
        config.Add(resource);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Lifecycle_IgnoreChangesAll_GeneratesHcl()
    {
        var config = new TerraformStack()
        {
            Name = "test"
        };

        var resource = new TerraformResource("aws_instance", "web");
        resource.WithProperty("ami", "ami-12345678");
        resource.Lifecycle = new TerraformLifecycleConfig
        {
            IgnoreChanges = { "all" }
        };
        config.Add(resource);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Lifecycle_Complete_GeneratesHcl()
    {
        var config = new TerraformStack()
        {
            Name = "test"
        };

        var resource = new TerraformResource("aws_instance", "web");
        resource.WithProperty("ami", "ami-12345678");
        resource.WithProperty("instance_type", "t2.micro");
        resource.Lifecycle = new TerraformLifecycleConfig
        {
            CreateBeforeDestroy = true,
            PreventDestroy = false,
            IgnoreChanges = { "tags" }
        };
        config.Add(resource);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Lifecycle_WithPrecondition_GeneratesHcl()
    {
        var config = new TerraformStack()
        {
            Name = "test"
        };

        var resource = new TerraformResource("aws_instance", "web");
        resource.WithProperty("ami", "ami-12345678");
        resource.WithProperty("instance_type", "t2.micro");
        resource.DeclareOutput("ami");

        resource.Lifecycle = new TerraformLifecycleConfig
        {
            CreateBeforeDestroy = true,
            PreventDestroy = false
        };
        // TODO: Add support for preconditions/postconditions through construct pattern
        // Preconditions = { new LifecycleCheck { Condition = ..., ErrorMessage = ... } }
        config.Add(resource);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Lifecycle_WithPostcondition_GeneratesHcl()
    {
        var config = new TerraformStack()
        {
            Name = "test"
        };

        var resource = new TerraformResource("aws_instance", "web");
        resource.WithProperty("ami", "ami-12345678");
        resource.WithProperty("instance_type", "t2.micro");
        resource.DeclareOutput("public_ip");

        resource.Lifecycle = new TerraformLifecycleConfig
        {
            CreateBeforeDestroy = true
        };
        // TODO: Add support for preconditions/postconditions through construct pattern
        // Postconditions = { new LifecycleCheck { Condition = ..., ErrorMessage = ... } }
        config.Add(resource);

        return Verify(config.ToHcl());
    }
}

