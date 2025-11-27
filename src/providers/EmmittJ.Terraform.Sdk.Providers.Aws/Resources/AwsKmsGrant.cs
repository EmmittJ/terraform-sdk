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
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "encryption_context_equals").ResolveNodes(ctx));
        set => SetArgument("encryption_context_equals", value);
    }

    /// <summary>
    /// The encryption_context_subset attribute.
    /// </summary>
    public TerraformMap<string>? EncryptionContextSubset
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "encryption_context_subset").ResolveNodes(ctx));
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "grant_creation_tokens").ResolveNodes(ctx));
        set => SetArgument("grant_creation_tokens", value);
    }

    /// <summary>
    /// The grantee_principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GranteePrincipal is required")]
    public required TerraformValue<string> GranteePrincipal
    {
        get => new TerraformReference<string>(this, "grantee_principal");
        set => SetArgument("grantee_principal", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformValue<string> KeyId
    {
        get => new TerraformReference<string>(this, "key_id");
        set => SetArgument("key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The operations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operations is required")]
    public required TerraformSet<string> Operations
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "operations").ResolveNodes(ctx));
        set => SetArgument("operations", value);
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
    /// The retire_on_delete attribute.
    /// </summary>
    public TerraformValue<bool>? RetireOnDelete
    {
        get => new TerraformReference<bool>(this, "retire_on_delete");
        set => SetArgument("retire_on_delete", value);
    }

    /// <summary>
    /// The retiring_principal attribute.
    /// </summary>
    public TerraformValue<string>? RetiringPrincipal
    {
        get => new TerraformReference<string>(this, "retiring_principal");
        set => SetArgument("retiring_principal", value);
    }

    /// <summary>
    /// The grant_id attribute.
    /// </summary>
    public TerraformValue<string> GrantId
    {
        get => new TerraformReference<string>(this, "grant_id");
    }

    /// <summary>
    /// The grant_token attribute.
    /// </summary>
    public TerraformValue<string> GrantToken
    {
        get => new TerraformReference<string>(this, "grant_token");
    }

    /// <summary>
    /// Constraints block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsKmsGrantConstraintsBlock>? Constraints
    {
        get => GetArgument<TerraformSet<AwsKmsGrantConstraintsBlock>>("constraints");
        set => SetArgument("constraints", value);
    }

}
