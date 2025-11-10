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
        set => SetProperty("encryption_context_equals", value);
    }

    /// <summary>
    /// The encryption_context_subset attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EncryptionContextSubset
    {
        set => SetProperty("encryption_context_subset", value);
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
        SetOutput("grant_id");
        SetOutput("grant_token");
        SetOutput("grant_creation_tokens");
        SetOutput("grantee_principal");
        SetOutput("id");
        SetOutput("key_id");
        SetOutput("name");
        SetOutput("operations");
        SetOutput("region");
        SetOutput("retire_on_delete");
        SetOutput("retiring_principal");
    }

    /// <summary>
    /// The grant_creation_tokens attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> GrantCreationTokens
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("grant_creation_tokens");
        set => SetProperty("grant_creation_tokens", value);
    }

    /// <summary>
    /// The grantee_principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GranteePrincipal is required")]
    public required TerraformProperty<string> GranteePrincipal
    {
        get => GetRequiredOutput<TerraformProperty<string>>("grantee_principal");
        set => SetProperty("grantee_principal", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformProperty<string> KeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_id");
        set => SetProperty("key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The operations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operations is required")]
    public HashSet<TerraformProperty<string>> Operations
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("operations");
        set => SetProperty("operations", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The retire_on_delete attribute.
    /// </summary>
    public TerraformProperty<bool> RetireOnDelete
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("retire_on_delete");
        set => SetProperty("retire_on_delete", value);
    }

    /// <summary>
    /// The retiring_principal attribute.
    /// </summary>
    public TerraformProperty<string> RetiringPrincipal
    {
        get => GetRequiredOutput<TerraformProperty<string>>("retiring_principal");
        set => SetProperty("retiring_principal", value);
    }

    /// <summary>
    /// Block for constraints.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsKmsGrantConstraintsBlock>? Constraints
    {
        set => SetProperty("constraints", value);
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
