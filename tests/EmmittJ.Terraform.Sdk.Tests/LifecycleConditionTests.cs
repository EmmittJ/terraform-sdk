using EmmittJ.Terraform.Sdk.Core;

namespace EmmittJ.Terraform.Sdk.Tests;

public class LifecycleConditionTests
{
    [Fact]
    public Task Resource_WithPrecondition_GeneratesHcl()
    {
        var resource = new TerraformResource("aws_instance", "web")
        {
            Lifecycle = new TerraformLifecycleConfig
            {
                Preconditions =
                {
                    new TerraformCondition(
                        condition: "self.ami != null",
                        errorMessage: "AMI must be specified"
                    )
                }
            }
        };

        resource.WithProperty("instance_type", "t2.micro");

        return Verify(resource.Resolve());
    }

    [Fact]
    public Task Resource_WithPostcondition_GeneratesHcl()
    {
        var resource = new TerraformResource("aws_instance", "web")
        {
            Lifecycle = new TerraformLifecycleConfig
            {
                Postconditions =
                {
                    new TerraformCondition(
                        condition: "self.public_ip != \"\"",
                        errorMessage: "Instance must have a public IP"
                    )
                }
            }
        };

        resource.WithProperty("instance_type", "t2.micro");

        return Verify(resource.Resolve());
    }

    [Fact]
    public Task Resource_WithMultipleConditions_GeneratesHcl()
    {
        var resource = new TerraformResource("aws_instance", "web")
        {
            Lifecycle = new TerraformLifecycleConfig
            {
                Preconditions =
                {
                    new TerraformCondition(
                        condition: "var.environment != \"\"",
                        errorMessage: "Environment variable must be set"
                    ),
                    new TerraformCondition(
                        condition: "contains([\"dev\", \"staging\", \"prod\"], var.environment)",
                        errorMessage: "Environment must be dev, staging, or prod"
                    )
                },
                Postconditions =
                {
                    new TerraformCondition(
                        condition: "self.public_ip != \"\"",
                        errorMessage: "Instance must have a public IP"
                    ),
                    new TerraformCondition(
                        condition: "length(self.tags) > 0",
                        errorMessage: "Instance must have at least one tag"
                    )
                }
            }
        };

        resource.WithProperty("instance_type", "t2.micro");

        return Verify(resource.Resolve());
    }

    [Fact]
    public Task Resource_WithConditionsAndOtherLifecycleOptions_GeneratesHcl()
    {
        var resource = new TerraformResource("aws_instance", "web")
        {
            Lifecycle = new TerraformLifecycleConfig
            {
                CreateBeforeDestroy = true,
                PreventDestroy = false,
                IgnoreChanges = { "tags" },
                Preconditions =
                {
                    new TerraformCondition(
                        condition: "self.ami != null",
                        errorMessage: "AMI must be specified"
                    )
                },
                Postconditions =
                {
                    new TerraformCondition(
                        condition: "self.instance_state == \"running\"",
                        errorMessage: "Instance must be in running state"
                    )
                }
            }
        };

        resource.WithProperty("instance_type", "t2.micro");
        resource.WithProperty("ami", "ami-12345678");

        return Verify(resource.Resolve());
    }

    [Fact]
    public Task DataSource_WithPrecondition_GeneratesHcl()
    {
        var dataSource = new TerraformDataSource("aws_ami", "ubuntu")
        {
            Lifecycle = new TerraformLifecycleConfig
            {
                Preconditions =
                {
                    new TerraformCondition(
                        condition: "var.ami_filter != \"\"",
                        errorMessage: "AMI filter must be specified"
                    )
                }
            }
        };

        dataSource.WithProperty("most_recent", true);
        dataSource.WithProperty("owners", new[] { "099720109477" });

        return Verify(dataSource.Resolve());
    }

    [Fact]
    public Task DataSource_WithPostcondition_GeneratesHcl()
    {
        var dataSource = new TerraformDataSource("aws_ami", "ubuntu")
        {
            Lifecycle = new TerraformLifecycleConfig
            {
                Postconditions =
                {
                    new TerraformCondition(
                        condition: "self.image_id != \"\"",
                        errorMessage: "AMI must be found"
                    ),
                    new TerraformCondition(
                        condition: "self.state == \"available\"",
                        errorMessage: "AMI must be available"
                    )
                }
            }
        };

        dataSource.WithProperty("most_recent", true);

        return Verify(dataSource.Resolve());
    }

    [Fact]
    public Task Output_WithPrecondition_GeneratesHcl()
    {
        var output = new TerraformOutput("instance_ip")
        {
            Value = TerraformExpression.Identifier("aws_instance.web.public_ip"),
            Preconditions =
            {
                new TerraformCondition(
                    condition: "aws_instance.web.public_ip != \"\"",
                    errorMessage: "Instance must have a public IP before output"
                )
            }
        };

        return Verify(output.Resolve());
    }

    [Fact]
    public Task Output_WithMultiplePreconditions_GeneratesHcl()
    {
        var objExpr = new TerraformObjectExpression
        {
            ["id"] = TerraformExpression.Identifier("aws_instance.web.id"),
            ["ip"] = TerraformExpression.Identifier("aws_instance.web.public_ip")
        };

        var output = new TerraformOutput("instance_details")
        {
            Value = objExpr,
            Description = "Instance details",
            Preconditions =
            {
                new TerraformCondition(
                    condition: "aws_instance.web.id != \"\"",
                    errorMessage: "Instance must exist"
                ),
                new TerraformCondition(
                    condition: "aws_instance.web.public_ip != \"\"",
                    errorMessage: "Instance must have a public IP"
                )
            }
        };

        return Verify(output.Resolve());
    }

    [Fact]
    public void Condition_NullCondition_ThrowsException()
    {
        var exception = Assert.Throws<ArgumentException>(() =>
            new TerraformCondition(null!, "error message")
        );

        Assert.Contains("Condition cannot be null or empty", exception.Message);
    }

    [Fact]
    public void Condition_EmptyCondition_ThrowsException()
    {
        var exception = Assert.Throws<ArgumentException>(() =>
            new TerraformCondition("", "error message")
        );

        Assert.Contains("Condition cannot be null or empty", exception.Message);
    }

    [Fact]
    public void Condition_NullErrorMessage_ThrowsException()
    {
        var exception = Assert.Throws<ArgumentException>(() =>
            new TerraformCondition("true", null!)
        );

        Assert.Contains("Error message cannot be null or empty", exception.Message);
    }

    [Fact]
    public void Condition_EmptyErrorMessage_ThrowsException()
    {
        var exception = Assert.Throws<ArgumentException>(() =>
            new TerraformCondition("true", "")
        );

        Assert.Contains("Error message cannot be null or empty", exception.Message);
    }
}
