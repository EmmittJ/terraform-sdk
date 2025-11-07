using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_eks_addon resource.
/// </summary>
public class AwsEksAddon : TerraformResource
{
    public AwsEksAddon(string name) : base("aws_eks_addon", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_at");
        this.DeclareOutput("modified_at");
    }

    /// <summary>
    /// The addon_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AddonName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("addon_name");
        set => this.WithProperty("addon_name", value);
    }

    /// <summary>
    /// The addon_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AddonVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("addon_version");
        set => this.WithProperty("addon_version", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClusterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_name");
        set => this.WithProperty("cluster_name", value);
    }

    /// <summary>
    /// The configuration_values attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ConfigurationValues
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configuration_values");
        set => this.WithProperty("configuration_values", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The preserve attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Preserve
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("preserve");
        set => this.WithProperty("preserve", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The resolve_conflicts_on_create attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResolveConflictsOnCreate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resolve_conflicts_on_create");
        set => this.WithProperty("resolve_conflicts_on_create", value);
    }

    /// <summary>
    /// The resolve_conflicts_on_update attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResolveConflictsOnUpdate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resolve_conflicts_on_update");
        set => this.WithProperty("resolve_conflicts_on_update", value);
    }

    /// <summary>
    /// The service_account_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceAccountRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_account_role_arn");
        set => this.WithProperty("service_account_role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The modified_at attribute.
    /// </summary>
    public TerraformExpression ModifiedAt => this["modified_at"];

}
