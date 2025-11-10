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
    public TerraformProperty<string>? ClientId
    {
        get => GetProperty<TerraformProperty<string>>("client_id");
        set => this.WithProperty("client_id", value);
    }

    /// <summary>
    /// The css attribute.
    /// </summary>
    public TerraformProperty<string>? Css
    {
        get => GetProperty<TerraformProperty<string>>("css");
        set => this.WithProperty("css", value);
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
    /// The image_file attribute.
    /// </summary>
    public TerraformProperty<string>? ImageFile
    {
        get => GetProperty<TerraformProperty<string>>("image_file");
        set => this.WithProperty("image_file", value);
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
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformProperty<string> UserPoolId
    {
        get => GetProperty<TerraformProperty<string>>("user_pool_id");
        set => this.WithProperty("user_pool_id", value);
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
