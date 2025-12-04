using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cognito_user_pool_clients Terraform data source.
/// Retrieves information about a aws_cognito_user_pool_clients.
/// </summary>
public partial class AwsCognitoUserPoolClientsDataSource(string name) : TerraformDataSource("aws_cognito_user_pool_clients", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformValue<string> UserPoolId
    {
        get => GetArgument<TerraformValue<string>>("user_pool_id");
        set => SetArgument("user_pool_id", value);
    }

    /// <summary>
    /// The client_ids attribute.
    /// </summary>
    public TerraformList<string> ClientIds
        => AsReference("client_ids");

    /// <summary>
    /// The client_names attribute.
    /// </summary>
    public TerraformList<string> ClientNames
        => AsReference("client_names");

}
