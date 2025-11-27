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
        get => new TerraformReference<string>(this, "mode");
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
        get => new TerraformReference<string>(this, "deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The policy_store_id attribute.
    /// </summary>
    public TerraformValue<string> PolicyStoreId
    {
        get => new TerraformReference<string>(this, "policy_store_id");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// ValidationSettings block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsVerifiedpermissionsPolicyStoreValidationSettingsBlock>? ValidationSettings
    {
        get => GetArgument<TerraformList<AwsVerifiedpermissionsPolicyStoreValidationSettingsBlock>>("validation_settings");
        set => SetArgument("validation_settings", value);
    }

}
