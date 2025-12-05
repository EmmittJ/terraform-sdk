using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for validation_settings in AwsVerifiedpermissionsPolicyStore.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedpermissionsPolicyStoreValidationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "validation_settings";

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => GetRequiredArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

}


/// <summary>
/// Represents a aws_verifiedpermissions_policy_store Terraform resource.
/// Manages a aws_verifiedpermissions_policy_store resource.
/// </summary>
public partial class AwsVerifiedpermissionsPolicyStore(string name) : TerraformResource("aws_verifiedpermissions_policy_store", name)
{
    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformValue<string> DeletionProtection
    {
        get => GetArgument<TerraformValue<string>>("deletion_protection") ?? CreateReference("deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The policy_store_id attribute.
    /// </summary>
    public TerraformValue<string> PolicyStoreId
        => CreateReference("policy_store_id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

    /// <summary>
    /// ValidationSettings block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsVerifiedpermissionsPolicyStoreValidationSettingsBlock>? ValidationSettings
    {
        get => GetArgument<TerraformList<AwsVerifiedpermissionsPolicyStoreValidationSettingsBlock>>("validation_settings");
        set => SetArgument("validation_settings", value);
    }

}
