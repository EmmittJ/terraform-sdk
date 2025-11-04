using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cognito_user_in_group resource.
/// </summary>
public class AwsCognitoUserInGroup : TerraformResource
{
    public AwsCognitoUserInGroup(string name) : base("aws_cognito_user_in_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    public string? GroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group_name")?.Value;
        set => this.WithProperty("group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The username attribute.
    /// </summary>
    public string? Username
    {
        get => GetProperty<TerraformLiteralProperty<string>>("username")?.Value;
        set => this.WithProperty("username", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
