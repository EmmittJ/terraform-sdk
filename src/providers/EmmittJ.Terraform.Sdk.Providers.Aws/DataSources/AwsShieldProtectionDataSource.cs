using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_shield_protection Terraform data source.
/// Retrieves information about a aws_shield_protection.
/// </summary>
public partial class AwsShieldProtectionDataSource(string name) : TerraformDataSource("aws_shield_protection", name)
{
    /// <summary>
    /// The protection_id attribute.
    /// </summary>
    public TerraformValue<string> ProtectionId
    {
        get => new TerraformReference<string>(this, "protection_id");
        set => SetArgument("protection_id", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformValue<string> ResourceArn
    {
        get => new TerraformReference<string>(this, "resource_arn");
        set => SetArgument("resource_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The protection_arn attribute.
    /// </summary>
    public TerraformValue<string> ProtectionArn
    {
        get => new TerraformReference<string>(this, "protection_arn");
    }

}
