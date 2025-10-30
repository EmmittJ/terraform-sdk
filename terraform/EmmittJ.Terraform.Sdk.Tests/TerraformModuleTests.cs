namespace EmmittJ.Terraform.Sdk.Tests;

public class TerraformModuleTests
{
    [Fact]
    public void Module_GeneratesBasicHcl()
    {
        var module = new TerraformModule("vpc")
        {
            Source = "terraform-aws-modules/vpc/aws",
            Version = "5.0.0"
        };

        module.Set("cidr", "10.0.0.0/16");
        module.Set("azs", new[] { "us-west-2a", "us-west-2b" });

        var hcl = module.Resolve();

        Assert.Contains("module \"vpc\"", hcl);
        Assert.Contains("source = \"terraform-aws-modules/vpc/aws\"", hcl);
        Assert.Contains("version = \"5.0.0\"", hcl);
        Assert.Contains("cidr = ", hcl);
        Assert.Contains("azs = ", hcl);
    }

    [Fact]
    public void Module_GeneratesHclWithoutVersion()
    {
        var module = new TerraformModule("local_module")
        {
            Source = "./modules/networking"
        };

        module.Set("vpc_id", "vpc-123");

        var hcl = module.Resolve();

        Assert.Contains("module \"local_module\"", hcl);
        Assert.Contains("source = \"./modules/networking\"", hcl);
        Assert.DoesNotContain("version", hcl);
    }

    [Fact]
    public void Module_SupportsOutputReferences()
    {
        var module = new TerraformModule("vpc")
        {
            Source = "terraform-aws-modules/vpc/aws"
        };

        module.DeclareOutput("vpc_id");
        module.DeclareOutput("subnet_ids");

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

        var ex = Assert.Throws<TerraformConfigurationException>(() => module["vpc_id"]);
        Assert.Contains("has not been declared", ex.Message);
        Assert.Contains("DeclareOutput", ex.Message);
    }

    [Fact]
    public void Module_CanBeUsedInConfiguration()
    {
        var config = new TerraformConfiguration();

        var vpcModule = new TerraformModule("vpc")
        {
            Source = "terraform-aws-modules/vpc/aws",
            Version = "5.0.0"
        };
        vpcModule.Set("cidr", "10.0.0.0/16");
        vpcModule.DeclareOutput("vpc_id");

        var subnet = new TerraformResource("aws_subnet", "app");
        subnet.Set("vpc_id", vpcModule["vpc_id"]);

        config.Add(vpcModule);
        config.Add(subnet);

        var hcl = config.ToHcl();

        Assert.Contains("module \"vpc\"", hcl);
        Assert.Contains("resource \"aws_subnet\" \"app\"", hcl);
    }

    [Fact]
    public Task Module_HclSnapshot()
    {
        var module = new TerraformModule("vpc")
        {
            Source = "terraform-aws-modules/vpc/aws",
            Version = "5.0.0"
        };

        module.Set("cidr", "10.0.0.0/16");
        module.Set("azs", new[] { "us-west-2a", "us-west-2b", "us-west-2c" });
        module.Set("private_subnets", new[] { "10.0.1.0/24", "10.0.2.0/24", "10.0.3.0/24" });
        module.Set("public_subnets", new[] { "10.0.101.0/24", "10.0.102.0/24", "10.0.103.0/24" });
        module.Set("enable_nat_gateway", true);
        module.Set("enable_vpn_gateway", false);

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

        vpcModule.Set("region", region.AsReference());
        vpcModule.Set("cidr", "10.0.0.0/16");

        var config = new TerraformConfiguration();
        config.Add(region);
        config.Add(vpcModule);

        var hcl = config.ToHcl();

        return Verify(hcl);
    }

    [Fact]
    public void Module_GetReferenceExpression_ReturnsModuleDotName()
    {
        var module = new TerraformModule("vpc")
        {
            Source = "terraform-aws-modules/vpc/aws"
        };

        var expr = module.GetReferenceExpression();

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

        module.Set("region_var", region.AsReference());
        module.Set("cidr", "10.0.0.0/16");

        // Should not throw
        module.Prepare(context);
    }
}
