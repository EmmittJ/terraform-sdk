namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformDynamicBlockTests
{
    [Fact]
    public Task DynamicBlock_Simple_GeneratesCorrectHcl()
    {
        var resource = new TerraformResource("aws_security_group", "example")
        {
            DynamicBlocks =
            {
                new TerraformDynamicBlock("ingress", TerraformExpression.Identifier("var.ingress_rules"))
                    .WithContent("from_port", TerraformExpression.Identifier("ingress.value.from_port"))
                    .WithContent("to_port", TerraformExpression.Identifier("ingress.value.to_port"))
                    .WithContent("protocol", TerraformExpression.Identifier("ingress.value.protocol"))
                    .WithContent("cidr_blocks", TerraformExpression.Identifier("ingress.value.cidr_blocks"))
            }
        };

        resource["name"] = "example-sg");
        resource["vpc_id"] = TerraformExpression.Identifier("aws_vpc.main.id"));

        return Verify(resource.Resolve());
    }

    [Fact]
    public Task DynamicBlock_WithCustomIterator_GeneratesCorrectHcl()
    {
        var resource = new TerraformResource("aws_security_group", "example")
        {
            DynamicBlocks =
            {
                new TerraformDynamicBlock("egress", TerraformExpression.Identifier("var.egress_rules"))
                {
                    Iterator = "rule"
                }
                .WithContent("from_port", TerraformExpression.Identifier("rule.value.from_port"))
                .WithContent("to_port", TerraformExpression.Identifier("rule.value.to_port"))
                .WithContent("protocol", TerraformExpression.Identifier("rule.value.protocol"))
                .WithContent("cidr_blocks", TerraformExpression.Identifier("rule.value.cidr_blocks"))
            }
        };

        resource["name"] = "example-sg");

        return Verify(resource.Resolve());
    }

    [Fact]
    public Task DynamicBlock_Multiple_GeneratesCorrectHcl()
    {
        var resource = new TerraformResource("aws_security_group", "example")
        {
            DynamicBlocks =
            {
                new TerraformDynamicBlock("ingress", TerraformExpression.Identifier("var.ingress_rules"))
                    .WithContent("from_port", TerraformExpression.Identifier("ingress.value.from_port"))
                    .WithContent("to_port", TerraformExpression.Identifier("ingress.value.to_port"))
                    .WithContent("protocol", TerraformExpression.Identifier("ingress.value.protocol")),
                new TerraformDynamicBlock("egress", TerraformExpression.Identifier("var.egress_rules"))
                    .WithContent("from_port", TerraformExpression.Identifier("egress.value.from_port"))
                    .WithContent("to_port", TerraformExpression.Identifier("egress.value.to_port"))
                    .WithContent("protocol", TerraformExpression.Identifier("egress.value.protocol"))
            }
        };

        resource["name"] = "example-sg");
        resource["description"] = "Security group with dynamic rules");

        return Verify(resource.Resolve());
    }

    [Fact]
    public Task DynamicBlock_WithMap_GeneratesCorrectHcl()
    {
        var resource = new TerraformResource("aws_instance", "example")
        {
            DynamicBlocks =
            {
                new TerraformDynamicBlock("ebs_block_device", TerraformExpression.Identifier("var.ebs_volumes"))
                    .WithContent("device_name", TerraformExpression.Identifier("ebs_block_device.key"))
                    .WithContent("volume_size", TerraformExpression.Identifier("ebs_block_device.value.size"))
                    .WithContent("volume_type", TerraformExpression.Identifier("ebs_block_device.value.type"))
            }
        };

        resource["ami"] = "ami-12345678");
        resource["instance_type"] = "t2.micro");

        return Verify(resource.Resolve());
    }

    [Fact]
    public Task DynamicBlock_WithLiteralValues_GeneratesCorrectHcl()
    {
        var resource = new TerraformResource("aws_s3_bucket", "example")
        {
            DynamicBlocks =
            {
                new TerraformDynamicBlock("cors_rule", TerraformExpression.Identifier("var.cors_rules"))
                    .WithContent("allowed_headers", TerraformExpression.Identifier("cors_rule.value.allowed_headers"))
                    .WithContent("allowed_methods", TerraformExpression.Identifier("cors_rule.value.allowed_methods"))
                    .WithContent("allowed_origins", TerraformExpression.Identifier("cors_rule.value.allowed_origins"))
                    .WithContent("max_age_seconds", TerraformExpression.Literal(3000))
            }
        };

        resource["bucket"] = "my-bucket");

        return Verify(resource.Resolve());
    }

    [Fact]
    public Task DynamicBlock_Nested_GeneratesCorrectHcl()
    {
        var resource = new TerraformResource("aws_launch_template", "example")
        {
            DynamicBlocks =
            {
                new TerraformDynamicBlock("network_interfaces", TerraformExpression.Identifier("var.network_interfaces"))
                    .WithContent("device_index", TerraformExpression.Identifier("network_interfaces.value.device_index"))
                    .WithContent("associate_public_ip_address", TerraformExpression.Identifier("network_interfaces.value.public_ip"))
                    .WithContent("subnet_id", TerraformExpression.Identifier("network_interfaces.value.subnet_id"))
            }
        };

        resource["name"] = "example-template");
        resource["image_id"] = "ami-12345678");

        return Verify(resource.Resolve());
    }

    [Fact]
    public Task DynamicBlock_WithDictionaryContent_GeneratesCorrectHcl()
    {
        var contentProps = new Dictionary<string, TerraformExpression>
        {
            ["from_port"] = TerraformExpression.Identifier("ingress.value.from"),
            ["to_port"] = TerraformExpression.Identifier("ingress.value.to"),
            ["protocol"] = TerraformExpression.Literal("tcp"),
            ["cidr_blocks"] = TerraformExpression.Identifier("ingress.value.cidrs")
        };

        var resource = new TerraformResource("aws_security_group", "example")
        {
            DynamicBlocks =
            {
                new TerraformDynamicBlock("ingress", TerraformExpression.Identifier("var.ingress_rules"))
                    .WithContent(contentProps)
            }
        };

        resource["name"] = "example-sg");

        return Verify(resource.Resolve());
    }

    [Fact]
    public Task DynamicBlock_WithForExpression_GeneratesCorrectHcl()
    {
        var forExpr = TerraformExpression.ForList("rule", TerraformExpression.Identifier("var.all_rules"),
            TerraformExpression.Identifier("rule"),
            TerraformExpression.Raw("rule.enabled == true"));

        var resource = new TerraformResource("aws_security_group", "example")
        {
            DynamicBlocks =
            {
                new TerraformDynamicBlock("ingress", forExpr)
                    .WithContent("from_port", TerraformExpression.Identifier("ingress.value.from_port"))
                    .WithContent("to_port", TerraformExpression.Identifier("ingress.value.to_port"))
                    .WithContent("protocol", TerraformExpression.Identifier("ingress.value.protocol"))
            }
        };

        resource["name"] = "filtered-sg");

        return Verify(resource.Resolve());
    }

    [Fact]
    public Task DynamicBlock_WithLifecycle_GeneratesCorrectHcl()
    {
        var resource = new TerraformResource("aws_security_group", "example")
        {
            Lifecycle = new TerraformLifecycleConfig
            {
                CreateBeforeDestroy = true,
                IgnoreChanges = { "tags" }
            },
            DynamicBlocks =
            {
                new TerraformDynamicBlock("ingress", TerraformExpression.Identifier("var.ingress_rules"))
                    .WithContent("from_port", TerraformExpression.Identifier("ingress.value.from_port"))
                    .WithContent("to_port", TerraformExpression.Identifier("ingress.value.to_port"))
                    .WithContent("protocol", TerraformExpression.Identifier("ingress.value.protocol"))
            }
        };

        resource["name"] = "example-sg");

        return Verify(resource.Resolve());
    }

    [Fact]
    public Task DynamicBlock_DataSource_GeneratesCorrectHcl()
    {
        var dataSource = new TerraformDataSource("aws_availability_zones", "available")
        {
            DynamicBlocks =
            {
                new TerraformDynamicBlock("filter", TerraformExpression.Identifier("var.filters"))
                    .WithContent("name", TerraformExpression.Identifier("filter.value.name"))
                    .WithContent("values", TerraformExpression.Identifier("filter.value.values"))
            }
        };

        dataSource["state"] = "available");

        return Verify(dataSource.Resolve());
    }

    [Fact]
    public void DynamicBlock_NullBlockType_ThrowsException()
    {
        Assert.Throws<ArgumentNullException>(() =>
            new TerraformDynamicBlock(null!, TerraformExpression.Identifier("var.list")));
    }

    [Fact]
    public void DynamicBlock_NullForEach_ThrowsException()
    {
        Assert.Throws<ArgumentNullException>(() =>
            new TerraformDynamicBlock("ingress", null!));
    }

    [Fact]
    public void DynamicBlock_NullContentValue_ThrowsException()
    {
        var dynamicBlock = new TerraformDynamicBlock("ingress", TerraformExpression.Identifier("var.rules"));

        Assert.Throws<ArgumentNullException>(() =>
            dynamicBlock.WithContent("from_port", null!));
    }

    [Fact]
    public Task DynamicBlock_WithExtensionMethod_GeneratesCorrectHcl()
    {
        var resource = new TerraformResource("aws_security_group", "example");

        resource.WithDynamicBlock("ingress", TerraformExpression.Identifier("var.ingress_rules"), ingress =>
        {
            ingress.WithContent("from_port", ingress.Value["from_port"])
                   .WithContent("to_port", ingress.Value["to_port"])
                   .WithContent("protocol", ingress.Value["protocol"])
                   .WithContent("cidr_blocks", ingress.Value["cidr_blocks"]);
        });

        resource["name"] = "example-sg");
        resource["vpc_id"] = TerraformExpression.Identifier("aws_vpc.main.id"));

        return Verify(resource.Resolve());
    }

    [Fact]
    public Task DynamicBlock_WithCustomIteratorExtension_GeneratesCorrectHcl()
    {
        var resource = new TerraformResource("aws_security_group", "example");

        resource.WithDynamicBlock("egress", "rule", TerraformExpression.Identifier("var.egress_rules"), rule =>
        {
            rule.WithContent("from_port", rule.Value["from_port"])
                .WithContent("to_port", rule.Value["to_port"])
                .WithContent("protocol", rule.Value["protocol"])
                .WithContent("cidr_blocks", rule.Value["cidr_blocks"]);
        });

        resource["name"] = "example-sg");

        return Verify(resource.Resolve());
    }

    [Fact]
    public Task DynamicBlock_WithValueAccessor_GeneratesCorrectHcl()
    {
        var resource = new TerraformResource("aws_security_group", "example");

        resource.WithDynamicBlock("ingress", TerraformExpression.Identifier("var.ingress_rules"), ingress =>
        {
            // Using the Value property directly
            ingress.WithContent("from_port", ingress.Value["from_port"])
                   .WithContent("to_port", ingress.Value["to_port"])
                   .WithContent("protocol", TerraformExpression.Literal("tcp"));
        });

        resource["name"] = "example-sg");

        return Verify(resource.Resolve());
    }

    [Fact]
    public Task DynamicBlock_WithKeyAccessor_GeneratesCorrectHcl()
    {
        var resource = new TerraformResource("aws_instance", "example");

        resource.WithDynamicBlock("ebs_block_device", TerraformExpression.Identifier("var.ebs_volumes"), ebs =>
        {
            // Using Key and Value properties for map iteration
            ebs.WithContent("device_name", ebs.Key)
               .WithContent("volume_size", ebs.Value["size"])
               .WithContent("volume_type", ebs.Value["type"]);
        });

        resource["ami"] = "ami-12345678");
        resource["instance_type"] = "t2.micro");

        return Verify(resource.Resolve());
    }

    [Fact]
    public Task DynamicBlock_FluentChaining_GeneratesCorrectHcl()
    {
        var resource = new TerraformResource("aws_security_group", "example")
            .WithDynamicBlock("ingress", TerraformExpression.Identifier("var.ingress_rules"), ingress =>
            {
                ingress.WithContent("from_port", ingress.Value["from_port"])
                       .WithContent("to_port", ingress.Value["to_port"])
                       .WithContent("protocol", ingress.Value["protocol"]);
            })
            .WithDynamicBlock("egress", TerraformExpression.Identifier("var.egress_rules"), egress =>
            {
                egress.WithContent("from_port", egress.Value["from_port"])
                      .WithContent("to_port", egress.Value["to_port"])
                      .WithContent("protocol", egress.Value["protocol"]);
            });

        resource["name"] = "example-sg");
        resource["description"] = "Security group with fluent dynamic blocks");

        return Verify(resource.Resolve());
    }
}
