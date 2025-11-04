using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_guardduty_organization_configuration resource.
/// </summary>
public class AwsGuarddutyOrganizationConfiguration : TerraformResource
{
    public AwsGuarddutyOrganizationConfiguration(string name) : base("aws_guardduty_organization_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The auto_enable_organization_members attribute.
    /// </summary>
    public string? AutoEnableOrganizationMembers
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auto_enable_organization_members")?.Value;
        set => this.WithProperty("auto_enable_organization_members", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The detector_id attribute.
    /// </summary>
    public string? DetectorId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("detector_id")?.Value;
        set => this.WithProperty("detector_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
