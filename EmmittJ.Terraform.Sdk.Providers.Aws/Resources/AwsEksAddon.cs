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
    public string? AddonName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("addon_name")?.Value;
        set => this.WithProperty("addon_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The addon_version attribute.
    /// </summary>
    public string? AddonVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("addon_version")?.Value;
        set => this.WithProperty("addon_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The configuration_values attribute.
    /// </summary>
    public string? ConfigurationValues
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configuration_values")?.Value;
        set => this.WithProperty("configuration_values", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The preserve attribute.
    /// </summary>
    public bool? Preserve
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("preserve")?.Value;
        set => this.WithProperty("preserve", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The resolve_conflicts attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? ResolveConflicts
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resolve_conflicts")?.Value;
        set => this.WithProperty("resolve_conflicts", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resolve_conflicts_on_create attribute.
    /// </summary>
    public string? ResolveConflictsOnCreate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resolve_conflicts_on_create")?.Value;
        set => this.WithProperty("resolve_conflicts_on_create", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resolve_conflicts_on_update attribute.
    /// </summary>
    public string? ResolveConflictsOnUpdate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resolve_conflicts_on_update")?.Value;
        set => this.WithProperty("resolve_conflicts_on_update", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_account_role_arn attribute.
    /// </summary>
    public string? ServiceAccountRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_account_role_arn")?.Value;
        set => this.WithProperty("service_account_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
