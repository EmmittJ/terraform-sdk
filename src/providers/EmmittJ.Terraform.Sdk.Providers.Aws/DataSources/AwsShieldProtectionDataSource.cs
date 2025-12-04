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
        get => GetArgument<TerraformValue<string>>("protection_id") ?? AsReference("protection_id");
        set => SetArgument("protection_id", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformValue<string> ResourceArn
    {
        get => GetArgument<TerraformValue<string>>("resource_arn") ?? AsReference("resource_arn");
        set => SetArgument("resource_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The protection_arn attribute.
    /// </summary>
    public TerraformValue<string> ProtectionArn
        => AsReference("protection_arn");

}
