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
    public TerraformLiteralProperty<HashSet<string>>? GrantCreationTokens
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("grant_creation_tokens");
        set => this.WithProperty("grant_creation_tokens", value);
    }

    /// <summary>
    /// The grantee_principal attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GranteePrincipal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("grantee_principal");
        set => this.WithProperty("grantee_principal", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_id");
        set => this.WithProperty("key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The operations attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Operations
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("operations");
        set => this.WithProperty("operations", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The retire_on_delete attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RetireOnDelete
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("retire_on_delete");
        set => this.WithProperty("retire_on_delete", value);
    }

    /// <summary>
    /// The retiring_principal attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RetiringPrincipal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("retiring_principal");
        set => this.WithProperty("retiring_principal", value);
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
