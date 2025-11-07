using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_securityhub_organization_configuration resource.
/// </summary>
public class AwsSecurityhubOrganizationConfiguration : TerraformResource
{
    public AwsSecurityhubOrganizationConfiguration(string name) : base("aws_securityhub_organization_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The auto_enable attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoEnable
    {
        get => GetProperty<TerraformProperty<bool>>("auto_enable");
        set => this.WithProperty("auto_enable", value);
    }

    /// <summary>
    /// The auto_enable_standards attribute.
    /// </summary>
    public TerraformProperty<string>? AutoEnableStandards
    {
        get => GetProperty<TerraformProperty<string>>("auto_enable_standards");
        set => this.WithProperty("auto_enable_standards", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
