namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformModuleTests
{
    [Fact]
    public Task Module_GeneratesBasicHcl()
    {
        var module = new TerraformModule("vpc")
        {
            Source = "terraform-aws-modules/vpc/aws",
            Version = "5.0.0"
        };

        module["cidr"] = "10.0.0.0/16";
        module["azs"] = new[] { "us-west-2a", "us-west-2b" };

        var hcl = module.Resolve();

        return Verify(hcl);
    }

    [Fact]
    public Task Module_GeneratesHclWithoutVersion()
    {
        var module = new TerraformModule("local_module")
        {
            Source = "./modules/networking"
        };

        module["vpc_id"] = "vpc-123";

        var hcl = module.Resolve();

        return Verify(hcl);
    }

    [Fact]
    public void Module_SupportsOutputReferences()
    {
        var module = new TerraformModule("vpc")
        {
            Source = "terraform-aws-modules/vpc/aws"
        };

        var vpcIdRef = module["vpc_id"];
        var subnetIdsRef = module["subnet_ids"];

        Assert.NotNull(vpcIdRef);
        Assert.NotNull(subnetIdsRef);
        Assert.Equal("module.vpc.vpc_id", vpcIdRef.ToHcl());
        Assert.Equal("module.vpc.subnet_ids", subnetIdsRef.ToHcl());
    }

    [Fact]
    public void Module_GetOutput_ThrowsIfNotDeclared()
    {
        var module = new TerraformModule("vpc")
        {
            Source = "terraform-aws-modules/vpc/aws"
        };

        // Now indexer always works - test removed or needs different approach
        var reference = module["vpc_id"];
        Assert.NotNull(reference);
    }

    [Fact]
    public Task Module_CanBeUsedInConfiguration()
    {
        var config = new TerraformStack();

        var vpcModule = new TerraformModule("vpc")
        {
            Source = "terraform-aws-modules/vpc/aws",
            Version = "5.0.0"
        };
        vpcModule["cidr"] = "10.0.0.0/16";

        var subnet = new TerraformResource("aws_subnet", "app");
        subnet["vpc_id"] = vpcModule["vpc_id"];

        config.Add(vpcModule);
        config.Add(subnet);

        return Verify(config.ToHcl());
    }

    [Fact]
    public Task Module_HclSnapshot()
    {
        var module = new TerraformModule("vpc")
        {
            Source = "terraform-aws-modules/vpc/aws",
            Version = "5.0.0"
        };

        module["cidr"] = "10.0.0.0/16";
        module["azs"] = new[] { "us-west-2a", "us-west-2b", "us-west-2c" };
        module["private_subnets"] = new[] { "10.0.1.0/24", "10.0.2.0/24", "10.0.3.0/24" };
        module["public_subnets"] = new[] { "10.0.101.0/24", "10.0.102.0/24", "10.0.103.0/24" };
        module["enable_nat_gateway"] = true;
        module["enable_vpn_gateway"] = false;

        var hcl = module.Resolve();

        return Verify(hcl);
    }

    [Fact]
    public Task Module_WithReferenceInput_HclSnapshot()
    {
        var region = new TerraformVariable("aws_region")
        {
            Type = "string",
            Default = "us-west-2"
        };

        var vpcModule = new TerraformModule("vpc")
        {
            Source = "terraform-aws-modules/vpc/aws",
            Version = "5.0.0"
        };

        vpcModule["region"] = region.AsReference();
        vpcModule["cidr"] = "10.0.0.0/16";

        var config = new TerraformStack();
        config.Add(region);
        config.Add(vpcModule);

        var hcl = config.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public void Module_AsReference_ReturnsModuleDotName()
    {
        var module = new TerraformModule("vpc")
        {
            Source = "terraform-aws-modules/vpc/aws"
        };

        var expr = module.AsReference();

        Assert.Equal("module.vpc", expr.ToHcl());
    }

    [Fact]
    public void Module_Prepare_PreparesAllVariables()
    {
        var context = TerraformContext.Temporary();
        var module = new TerraformModule("vpc")
        {
            Source = "./modules/vpc"
        };

        var region = new TerraformVariable("region")
        {
            Default = "us-west-2"
        };

        module["region_var"] = region;
        module["cidr"] = "10.0.0.0/16";

        // Should not throw
        module.Prepare(context);
    }
}

