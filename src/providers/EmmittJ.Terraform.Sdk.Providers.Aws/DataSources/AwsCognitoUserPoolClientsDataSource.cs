using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cognito_user_pool_clients.
/// </summary>
public class AwsCognitoUserPoolClientsDataSource : TerraformDataSource
{
    public AwsCognitoUserPoolClientsDataSource(string name) : base("aws_cognito_user_pool_clients", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("client_ids");
        SetOutput("client_names");
        SetOutput("id");
        SetOutput("region");
        SetOutput("user_pool_id");
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
    /// The client_ids attribute.
    /// </summary>
    public TerraformExpression ClientIds => this["client_ids"];

    /// <summary>
    /// The client_names attribute.
    /// </summary>
    public TerraformExpression ClientNames => this["client_names"];

}
