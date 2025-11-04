using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cognito_identity_pool_roles_attachment resource.
/// </summary>
public class AwsCognitoIdentityPoolRolesAttachment : TerraformResource
{
    public AwsCognitoIdentityPoolRolesAttachment(string name) : base("aws_cognito_identity_pool_roles_attachment", name)
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
    /// The roles attribute.
    /// </summary>
    public Dictionary<string, string>? Roles
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("roles")?.Value;
        set => this.WithProperty("roles", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
