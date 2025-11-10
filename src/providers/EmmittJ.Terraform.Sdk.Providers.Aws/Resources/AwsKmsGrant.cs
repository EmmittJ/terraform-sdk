using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for constraints in .
/// Nesting mode: set
/// </summary>
public class AwsKmsGrantConstraintsBlock : TerraformBlock
{
    /// <summary>
    /// The encryption_context_equals attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EncryptionContextEquals
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("encryption_context_equals");
        set => WithProperty("encryption_context_equals", value);
    }

    /// <summary>
    /// The encryption_context_subset attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EncryptionContextSubset
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("encryption_context_subset");
        set => WithProperty("encryption_context_subset", value);
    }

}

/// <summary>
/// Manages a aws_kms_grant resource.
/// </summary>
public class AwsKmsGrant : TerraformResource
{
    public AwsKmsGrant(string name) : base("aws_kms_grant", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("grant_id");
        this.WithOutput("grant_token");
    }

    /// <summary>
    /// The grant_creation_tokens attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? GrantCreationTokens
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("grant_creation_tokens");
        set => this.WithProperty("grant_creation_tokens", value);
    }

    /// <summary>
    /// The grantee_principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GranteePrincipal is required")]
    public required TerraformProperty<string> GranteePrincipal
    {
        get => GetRequiredProperty<TerraformProperty<string>>("grantee_principal");
        set => this.WithProperty("grantee_principal", value);
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
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformProperty<string> KeyId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key_id");
        set => this.WithProperty("key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The operations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operations is required")]
    public HashSet<TerraformProperty<string>>? Operations
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("operations");
        set => this.WithProperty("operations", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The retire_on_delete attribute.
    /// </summary>
    public TerraformProperty<bool>? RetireOnDelete
    {
        get => GetProperty<TerraformProperty<bool>>("retire_on_delete");
        set => this.WithProperty("retire_on_delete", value);
    }

    /// <summary>
    /// The retiring_principal attribute.
    /// </summary>
    public TerraformProperty<string>? RetiringPrincipal
    {
        get => GetProperty<TerraformProperty<string>>("retiring_principal");
        set => this.WithProperty("retiring_principal", value);
    }

    /// <summary>
    /// Block for constraints.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsKmsGrantConstraintsBlock>? Constraints
    {
        get => GetProperty<HashSet<AwsKmsGrantConstraintsBlock>>("constraints");
        set => this.WithProperty("constraints", value);
    }

    /// <summary>
    /// The grant_id attribute.
    /// </summary>
    public TerraformExpression GrantId => this["grant_id"];

    /// <summary>
    /// The grant_token attribute.
    /// </summary>
    public TerraformExpression GrantToken => this["grant_token"];

}
