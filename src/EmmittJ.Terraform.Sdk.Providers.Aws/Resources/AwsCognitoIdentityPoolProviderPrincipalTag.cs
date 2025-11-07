using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cognito_identity_pool_provider_principal_tag resource.
/// </summary>
public class AwsCognitoIdentityPoolProviderPrincipalTag : TerraformResource
{
    public AwsCognitoIdentityPoolProviderPrincipalTag(string name) : base("aws_cognito_identity_pool_provider_principal_tag", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The identity_pool_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IdentityPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_pool_id");
        set => this.WithProperty("identity_pool_id", value);
    }

    /// <summary>
    /// The identity_provider_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IdentityProviderName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_provider_name");
        set => this.WithProperty("identity_provider_name", value);
    }

    /// <summary>
    /// The principal_tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? PrincipalTags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("principal_tags");
        set => this.WithProperty("principal_tags", value);
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
    /// The use_defaults attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? UseDefaults
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_defaults");
        set => this.WithProperty("use_defaults", value);
    }

}
