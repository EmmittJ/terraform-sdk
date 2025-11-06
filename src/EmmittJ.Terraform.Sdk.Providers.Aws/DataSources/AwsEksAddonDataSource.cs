using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_eks_addon.
/// </summary>
public class AwsEksAddonDataSource : TerraformDataSource
{
    public AwsEksAddonDataSource(string name) : base("aws_eks_addon", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("addon_version");
        this.DeclareOutput("arn");
        this.DeclareOutput("configuration_values");
        this.DeclareOutput("created_at");
        this.DeclareOutput("modified_at");
        this.DeclareOutput("pod_identity_association");
        this.DeclareOutput("service_account_role_arn");
    }

    /// <summary>
    /// The addon_name attribute.
    /// </summary>
    public string? AddonName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("addon_name")?.Value;
        set => this.WithProperty("addon_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public string? ClusterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_name")?.Value;
        set => this.WithProperty("cluster_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The addon_version attribute.
    /// </summary>
    public TerraformExpression AddonVersion => this["addon_version"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The configuration_values attribute.
    /// </summary>
    public TerraformExpression ConfigurationValues => this["configuration_values"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The modified_at attribute.
    /// </summary>
    public TerraformExpression ModifiedAt => this["modified_at"];

    /// <summary>
    /// The pod_identity_association attribute.
    /// </summary>
    public TerraformExpression PodIdentityAssociation => this["pod_identity_association"];

    /// <summary>
    /// The service_account_role_arn attribute.
    /// </summary>
    public TerraformExpression ServiceAccountRoleArn => this["service_account_role_arn"];

}
