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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The identity_pool_id attribute.
    /// </summary>
    public string? IdentityPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_pool_id")?.Value;
        set => this.WithProperty("identity_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The identity_provider_name attribute.
    /// </summary>
    public string? IdentityProviderName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_provider_name")?.Value;
        set => this.WithProperty("identity_provider_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The principal_tags attribute.
    /// </summary>
    public Dictionary<string, string>? PrincipalTags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("principal_tags")?.Value;
        set => this.WithProperty("principal_tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The use_defaults attribute.
    /// </summary>
    public bool? UseDefaults
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_defaults")?.Value;
        set => this.WithProperty("use_defaults", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
