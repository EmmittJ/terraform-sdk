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
    /// The auto_enable attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public bool? AutoEnable
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_enable")?.Value;
        set => this.WithProperty("auto_enable", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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

}
