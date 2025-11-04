using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cognito_managed_login_branding resource.
/// </summary>
public class AwsCognitoManagedLoginBranding : TerraformResource
{
    public AwsCognitoManagedLoginBranding(string name) : base("aws_cognito_managed_login_branding", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("managed_login_branding_id");
        this.DeclareOutput("settings_all");
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public string? ClientId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_id")?.Value;
        set => this.WithProperty("client_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The settings attribute.
    /// </summary>
    public string? Settings
    {
        get => GetProperty<TerraformLiteralProperty<string>>("settings")?.Value;
        set => this.WithProperty("settings", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The use_cognito_provided_values attribute.
    /// </summary>
    public bool? UseCognitoProvidedValues
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_cognito_provided_values")?.Value;
        set => this.WithProperty("use_cognito_provided_values", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    public string? UserPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_pool_id")?.Value;
        set => this.WithProperty("user_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed_login_branding_id attribute.
    /// </summary>
    public TerraformExpression ManagedLoginBrandingId => this["managed_login_branding_id"];

    /// <summary>
    /// The settings_all attribute.
    /// </summary>
    public TerraformExpression SettingsAll => this["settings_all"];

}
