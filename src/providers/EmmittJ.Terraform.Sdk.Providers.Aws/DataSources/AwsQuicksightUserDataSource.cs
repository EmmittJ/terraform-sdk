using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_quicksight_user.
/// </summary>
public class AwsQuicksightUserDataSource : TerraformDataSource
{
    public AwsQuicksightUserDataSource(string name) : base("aws_quicksight_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("active");
        SetOutput("arn");
        SetOutput("custom_permissions_name");
        SetOutput("email");
        SetOutput("identity_type");
        SetOutput("principal_id");
        SetOutput("user_role");
        SetOutput("aws_account_id");
        SetOutput("id");
        SetOutput("namespace");
        SetOutput("region");
        SetOutput("user_name");
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformProperty<string> AwsAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("aws_account_id");
        set => SetProperty("aws_account_id", value);
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
    /// The namespace attribute.
    /// </summary>
    public TerraformProperty<string> Namespace
    {
        get => GetRequiredOutput<TerraformProperty<string>>("namespace");
        set => SetProperty("namespace", value);
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
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformProperty<string> UserName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_name");
        set => SetProperty("user_name", value);
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    public TerraformExpression Active => this["active"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The custom_permissions_name attribute.
    /// </summary>
    public TerraformExpression CustomPermissionsName => this["custom_permissions_name"];

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformExpression Email => this["email"];

    /// <summary>
    /// The identity_type attribute.
    /// </summary>
    public TerraformExpression IdentityType => this["identity_type"];

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformExpression PrincipalId => this["principal_id"];

    /// <summary>
    /// The user_role attribute.
    /// </summary>
    public TerraformExpression UserRole => this["user_role"];

}
