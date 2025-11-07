using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appfabric_app_authorization_connection resource.
/// </summary>
public class AwsAppfabricAppAuthorizationConnection : TerraformResource
{
    public AwsAppfabricAppAuthorizationConnection(string name) : base("aws_appfabric_app_authorization_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("app");
        this.DeclareOutput("id");
        this.DeclareOutput("tenant");
    }

    /// <summary>
    /// The app_authorization_arn attribute.
    /// </summary>
    public TerraformProperty<string>? AppAuthorizationArn
    {
        get => GetProperty<TerraformProperty<string>>("app_authorization_arn");
        set => this.WithProperty("app_authorization_arn", value);
    }

    /// <summary>
    /// The app_bundle_arn attribute.
    /// </summary>
    public TerraformProperty<string>? AppBundleArn
    {
        get => GetProperty<TerraformProperty<string>>("app_bundle_arn");
        set => this.WithProperty("app_bundle_arn", value);
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
    /// The app attribute.
    /// </summary>
    public TerraformExpression App => this["app"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tenant attribute.
    /// </summary>
    public TerraformExpression Tenant => this["tenant"];

}
