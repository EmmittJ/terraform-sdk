using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for constraints in AwsKmsGrant.
/// Nesting mode: set
/// </summary>
public class AwsKmsGrantConstraintsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "constraints";

    /// <summary>
    /// The encryption_context_equals attribute.
    /// </summary>
    public TerraformMap<string>? EncryptionContextEquals
    {
        get => GetArgument<TerraformMap<string>>("encryption_context_equals");
        set => SetArgument("encryption_context_equals", value);
    }

    /// <summary>
    /// The encryption_context_subset attribute.
    /// </summary>
    public TerraformMap<string>? EncryptionContextSubset
    {
        get => GetArgument<TerraformMap<string>>("encryption_context_subset");
        set => SetArgument("encryption_context_subset", value);
    }

}


/// <summary>
/// Represents a aws_kms_grant Terraform resource.
/// Manages a aws_kms_grant resource.
/// </summary>
public partial class AwsKmsGrant(string name) : TerraformResource("aws_kms_grant", name)
{
    /// <summary>
    /// The grant_creation_tokens attribute.
    /// </summary>
    public TerraformSet<string>? GrantCreationTokens
    {
        get => GetArgument<TerraformSet<string>>("grant_creation_tokens");
        set => SetArgument("grant_creation_tokens", value);
    }

    /// <summary>
    /// The grantee_principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GranteePrincipal is required")]
    public required TerraformValue<string> GranteePrincipal
    {
        get => GetRequiredArgument<TerraformValue<string>>("grantee_principal");
        set => SetArgument("grantee_principal", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformValue<string> KeyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_id");
        set => SetArgument("key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The operations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operations is required")]
    public required TerraformSet<string> Operations
    {
        get => GetRequiredArgument<TerraformSet<string>>("operations");
        set => SetArgument("operations", value);
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
    /// The retire_on_delete attribute.
    /// </summary>
    public TerraformValue<bool>? RetireOnDelete
    {
        get => GetArgument<TerraformValue<bool>>("retire_on_delete");
        set => SetArgument("retire_on_delete", value);
    }

    /// <summary>
    /// The retiring_principal attribute.
    /// </summary>
    public TerraformValue<string>? RetiringPrincipal
    {
        get => GetArgument<TerraformValue<string>>("retiring_principal");
        set => SetArgument("retiring_principal", value);
    }

    /// <summary>
    /// The grant_id attribute.
    /// </summary>
    public TerraformValue<string> GrantId
        => CreateReference("grant_id");

    /// <summary>
    /// The grant_token attribute.
    /// </summary>
    public TerraformValue<string> GrantToken
        => CreateReference("grant_token");

    /// <summary>
    /// Constraints block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsKmsGrantConstraintsBlock>? Constraints
    {
        get => GetArgument<TerraformSet<AwsKmsGrantConstraintsBlock>>("constraints");
        set => SetArgument("constraints", value);
    }

}
