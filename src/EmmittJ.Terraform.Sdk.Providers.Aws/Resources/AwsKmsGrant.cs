using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("grant_id");
        this.DeclareOutput("grant_token");
    }

    /// <summary>
    /// The grant_creation_tokens attribute.
    /// </summary>
    public HashSet<string>? GrantCreationTokens
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("grant_creation_tokens")?.Value;
        set => this.WithProperty("grant_creation_tokens", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The grantee_principal attribute.
    /// </summary>
    public string? GranteePrincipal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("grantee_principal")?.Value;
        set => this.WithProperty("grantee_principal", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    public string? KeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_id")?.Value;
        set => this.WithProperty("key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The operations attribute.
    /// </summary>
    public HashSet<string>? Operations
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("operations")?.Value;
        set => this.WithProperty("operations", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The retire_on_delete attribute.
    /// </summary>
    public bool? RetireOnDelete
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("retire_on_delete")?.Value;
        set => this.WithProperty("retire_on_delete", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The retiring_principal attribute.
    /// </summary>
    public string? RetiringPrincipal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("retiring_principal")?.Value;
        set => this.WithProperty("retiring_principal", value == null ? null : new TerraformLiteralProperty<string>(value));
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
