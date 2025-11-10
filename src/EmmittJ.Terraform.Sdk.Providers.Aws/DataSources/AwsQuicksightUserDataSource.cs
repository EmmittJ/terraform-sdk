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
        this.DeclareOutput("active");
        this.DeclareOutput("arn");
        this.DeclareOutput("custom_permissions_name");
        this.DeclareOutput("email");
        this.DeclareOutput("identity_type");
        this.DeclareOutput("principal_id");
        this.DeclareOutput("user_role");
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AwsAccountId
    {
        get => GetProperty<TerraformProperty<string>>("aws_account_id");
        set => this.WithProperty("aws_account_id", value);
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
    /// The namespace attribute.
    /// </summary>
    public TerraformProperty<string>? Namespace
    {
        get => GetProperty<TerraformProperty<string>>("namespace");
        set => this.WithProperty("namespace", value);
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
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformProperty<string> UserName
    {
        get => GetProperty<TerraformProperty<string>>("user_name");
        set => this.WithProperty("user_name", value);
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
