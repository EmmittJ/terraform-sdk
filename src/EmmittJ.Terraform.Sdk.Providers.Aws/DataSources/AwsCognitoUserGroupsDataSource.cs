using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cognito_user_groups.
/// </summary>
public class AwsCognitoUserGroupsDataSource : TerraformDataSource
{
    public AwsCognitoUserGroupsDataSource(string name) : base("aws_cognito_user_groups", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("groups");
        this.DeclareOutput("id");
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
    /// The groups attribute.
    /// </summary>
    public TerraformExpression Groups => this["groups"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
