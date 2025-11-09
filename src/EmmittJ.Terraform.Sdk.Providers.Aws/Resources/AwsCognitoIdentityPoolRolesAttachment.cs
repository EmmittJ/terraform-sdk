using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cognito_identity_pool_roles_attachment resource.
/// </summary>
public class AwsCognitoIdentityPoolRolesAttachment : TerraformResource
{
    public AwsCognitoIdentityPoolRolesAttachment(string name) : base("aws_cognito_identity_pool_roles_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The identity_pool_id attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityPoolId
    {
        get => GetProperty<TerraformProperty<string>>("identity_pool_id");
        set => this.WithProperty("identity_pool_id", value);
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
    /// The roles attribute.
    /// </summary>
    public TerraformMapProperty<string>? Roles
    {
        get => GetProperty<TerraformMapProperty<string>>("roles");
        set => this.WithProperty("roles", value);
    }

}
