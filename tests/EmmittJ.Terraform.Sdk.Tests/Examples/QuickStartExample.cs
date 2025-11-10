namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Example demonstrating how to use the SDK to create AWS infrastructure.
/// This example creates a VPC with multiple subnets across availability zones.
/// </summary>
public static class QuickStartExample
{
    /// <summary>
    /// Creates a complete AWS VPC example with variables, provider, and resources.
    /// Demonstrates: variables, resources, references, outputs, and Terraform functions.
    /// </summary>
    public static TerraformStack CreateAwsVpcExample()
    {
        var config = new TerraformStack();

        // Define variables
        var awsRegion = new TerraformVariable("aws_region")
        {
            Description = "AWS region to deploy to",
            Type = Tf.Types.String,
            Default = "us-east-1"
        };
        config.Add(awsRegion);

        var baseCidrBlock = new TerraformVariable("base_cidr_block")
        {
            Description = "A /16 CIDR range definition, such as 10.1.0.0/16, that the VPC will use",
            Default = "10.1.0.0/16",
            Type = Tf.Types.String
        };
        config.Add(baseCidrBlock);

        var availabilityZones = new TerraformVariable("availability_zones")
        {
            Description = "A list of availability zones in which to create subnets",
            Type = Tf.Types.List(Tf.Types.String)
            // Note: Default value for complex types like lists should be set using TerraformExpression if needed
            // For this example, we'll leave it as required input
        };
        config.Add(availabilityZones);

        // Define locals for common values
        var locals = new TerraformLocal()
            .WithProperty("project_name", "example-vpc")
            .WithProperty("environment", "production");
        locals
            .WithProperty("common_tags", new TerraformMapExpression
            {
                ["Environment"] = locals["environment"],
                ["Project"] = locals["project_name"],
                ["ManagedBy"] = "Terraform"
            });
        config.Add(locals);

        // Define AWS provider
        var awsProvider = new TerraformProvider("aws")
            .WithReference("region", awsRegion)
            .WithProperty("default_tags", new TerraformBlockExpression
            {
                ["tags"] = locals["common_tags"]
            });
        config.Add(awsProvider);

        // Create VPC resource
        var vpc = new TerraformResource("aws_vpc", "main")
            .WithReference("cidr_block", baseCidrBlock)
            .WithProperty("enable_dns_hostnames", true)
            .WithProperty("enable_dns_support", true)
            .WithProperty("tags", Tf.Functions.Merge(
                locals["common_tags"],
                new TerraformMapExpression
                {
                    ["Name"] = TerraformExpression.Interpolate(locals["project_name"], "-vpc")
                }))
            .WithOutput("id")
            .WithOutput("cidr_block");
        config.Add(vpc);

        // Create internet gateway
        var igw = new TerraformResource("aws_internet_gateway", "main")
            .WithProperty("vpc_id", vpc["id"])
            .WithProperty("tags", Tf.Functions.Merge(
                locals["common_tags"],
                new TerraformMapExpression
                {
                    ["Name"] = TerraformExpression.Interpolate(locals["project_name"], "-igw")
                }))
            .WithOutput("id");
        config.Add(igw);

        // Create subnets using for_each
        var subnets = new TerraformResource("aws_subnet", "public")
            .WithProperty("for_each", Tf.Functions.ToSet(availabilityZones.AsReference()))
            .WithProperty("vpc_id", vpc["id"])
            .WithProperty("availability_zone", Tf.Helpers.EachValue)
            .WithProperty("cidr_block", Tf.Functions.CidrSubnet(
                baseCidrBlock.AsReference(),
                4,
                Tf.Functions.Index(
                    availabilityZones.AsReference(),
                    Tf.Helpers.EachValue) + 1))
            .WithProperty("map_public_ip_on_launch", true)
            .WithProperty("tags", Tf.Functions.Merge(
                locals["common_tags"],
                new TerraformMapExpression
                {
                    ["Name"] = TerraformExpression.Interpolate(locals["project_name"], "-public-", Tf.Helpers.EachValue),
                    ["Tier"] = "Public"
                }))
            .WithOutput("id")
            .WithOutput("cidr_block");
        config.Add(subnets);

        // Output VPC ID
        var vpcIdOutput = new TerraformOutput("vpc_id")
        {
            Description = "The ID of the VPC",
            Value = vpc["id"]
        };
        config.Add(vpcIdOutput);

        // Output subnet IDs
        var subnetIdsOutput = new TerraformOutput("subnet_ids")
        {
            Description = "Map of subnet IDs by availability zone",
            Value = TerraformExpression.ForMap(
                "az",
                "subnet",
                subnets.AsReference(),
                (az, subnet) => (az, subnet["id"]))
        };
        config.Add(subnetIdsOutput);

        return config;
    }

    /// <summary>
    /// Simple example demonstrating basic features.
    /// </summary>
    public static TerraformStack CreateSimpleExample()
    {
        var config = new TerraformStack()
        {
            Name = "simple"
        };

        // Variable
        var region = new TerraformVariable("region")
        {
            Default = "us-west-2",
            Type = Tf.Types.String
        };
        config.Add(region);

        // Provider
        var aws = new TerraformProvider("aws")
            .WithReference("region", region);
        config.Add(aws);

        // Resource
        var bucket = new TerraformResource("aws_s3_bucket", "example")
            .WithProperty("bucket", Tf.Functions.Format("%s-bucket", region.AsReference()))
            .WithOutput("arn");
        config.Add(bucket);

        // Output
        var output = new TerraformOutput("bucket_arn")
        {
            Value = bucket["arn"]
        };
        config.Add(output);

        return config;
    }

    /// <summary>
    /// Demonstrates Terraform functions.
    /// </summary>
    public static TerraformStack CreateFunctionExample()
    {
        var config = new TerraformStack()
        {
            Name = "functions"
        };

        // Using Tf helper functions
        var locals = new TerraformLocal()
            .WithProperty("vpc_cidr", "10.0.0.0/16")
            .WithProperty("subnet_count", 3)
            .WithProperty("formatted_name", Tf.Functions.Format("app-%s-%s", "prod", "web"))
            .WithProperty("region_list", new List<string>() { "us-east-1", "us-west-2" });
        locals
            .WithProperty("subnet_cidrs", TerraformExpression.ForList(
                "i",
                Tf.Functions.Range(locals["subnet_count"]),
                i => Tf.Functions.CidrSubnet(
                    locals["vpc_cidr"],
                    8,
                    i)))
            .WithProperty("region_count", Tf.Functions.Length(locals["region_list"]));

        config.Add(locals);

        return config;
    }

    /// <summary>
    /// Demo method to print the generated HCL.
    /// </summary>
    public static void Demo()
    {
        Console.WriteLine("=== AWS VPC Example ===");
        Console.WriteLine(CreateAwsVpcExample().ToHcl());
        Console.WriteLine();

        Console.WriteLine("=== Simple Example ===");
        Console.WriteLine(CreateSimpleExample().ToHcl());
        Console.WriteLine();

        Console.WriteLine("=== Function Example ===");
        Console.WriteLine(CreateFunctionExample().ToHcl());
    }
}

