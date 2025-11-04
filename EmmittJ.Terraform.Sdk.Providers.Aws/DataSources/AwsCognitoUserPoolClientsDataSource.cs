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
        this.DeclareOutput("client_ids");
        this.DeclareOutput("client_names");
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
    /// The user_pool_id attribute.
    /// </summary>
    public string? UserPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_pool_id")?.Value;
        set => this.WithProperty("user_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
