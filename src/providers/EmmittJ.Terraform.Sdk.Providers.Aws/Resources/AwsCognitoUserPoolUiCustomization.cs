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
        SetOutput("creation_date");
        SetOutput("css_version");
        SetOutput("image_url");
        SetOutput("last_modified_date");
        SetOutput("client_id");
        SetOutput("css");
        SetOutput("id");
        SetOutput("image_file");
        SetOutput("region");
        SetOutput("user_pool_id");
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformProperty<string> ClientId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_id");
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The css attribute.
    /// </summary>
    public TerraformProperty<string> Css
    {
        get => GetRequiredOutput<TerraformProperty<string>>("css");
        set => SetProperty("css", value);
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
    /// The image_file attribute.
    /// </summary>
    public TerraformProperty<string> ImageFile
    {
        get => GetRequiredOutput<TerraformProperty<string>>("image_file");
        set => SetProperty("image_file", value);
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
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformProperty<string> UserPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_pool_id");
        set => SetProperty("user_pool_id", value);
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
