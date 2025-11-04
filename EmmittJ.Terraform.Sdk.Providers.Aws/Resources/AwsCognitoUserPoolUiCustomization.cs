using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cognito_user_pool_ui_customization resource.
/// </summary>
public class AwsCognitoUserPoolUiCustomization : TerraformResource
{
    public AwsCognitoUserPoolUiCustomization(string name) : base("aws_cognito_user_pool_ui_customization", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_date");
        this.DeclareOutput("css_version");
        this.DeclareOutput("image_url");
        this.DeclareOutput("last_modified_date");
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
    /// The css attribute.
    /// </summary>
    public string? Css
    {
        get => GetProperty<TerraformLiteralProperty<string>>("css")?.Value;
        set => this.WithProperty("css", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The image_file attribute.
    /// </summary>
    public string? ImageFile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_file")?.Value;
        set => this.WithProperty("image_file", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The creation_date attribute.
    /// </summary>
    public TerraformExpression CreationDate => this["creation_date"];

    /// <summary>
    /// The css_version attribute.
    /// </summary>
    public TerraformExpression CssVersion => this["css_version"];

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    public TerraformExpression ImageUrl => this["image_url"];

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    public TerraformExpression LastModifiedDate => this["last_modified_date"];

}
