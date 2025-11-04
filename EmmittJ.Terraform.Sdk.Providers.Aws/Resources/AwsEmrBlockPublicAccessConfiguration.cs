using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_emr_block_public_access_configuration resource.
/// </summary>
public class AwsEmrBlockPublicAccessConfiguration : TerraformResource
{
    public AwsEmrBlockPublicAccessConfiguration(string name) : base("aws_emr_block_public_access_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The block_public_security_group_rules attribute.
    /// </summary>
    public bool? BlockPublicSecurityGroupRules
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("block_public_security_group_rules")?.Value;
        set => this.WithProperty("block_public_security_group_rules", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
