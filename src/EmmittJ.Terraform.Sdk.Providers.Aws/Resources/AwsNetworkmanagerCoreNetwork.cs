using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_networkmanager_core_network resource.
/// </summary>
public class AwsNetworkmanagerCoreNetwork : TerraformResource
{
    public AwsNetworkmanagerCoreNetwork(string name) : base("aws_networkmanager_core_network", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("created_at");
        this.DeclareOutput("edges");
        this.DeclareOutput("segments");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The base_policy_document attribute.
    /// </summary>
    public TerraformProperty<string>? BasePolicyDocument
    {
        get => GetProperty<TerraformProperty<string>>("base_policy_document");
        set => this.WithProperty("base_policy_document", value);
    }

    /// <summary>
    /// The base_policy_regions attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? BasePolicyRegions
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("base_policy_regions");
        set => this.WithProperty("base_policy_regions", value);
    }

    /// <summary>
    /// The create_base_policy attribute.
    /// </summary>
    public TerraformProperty<bool>? CreateBasePolicy
    {
        get => GetProperty<TerraformProperty<bool>>("create_base_policy");
        set => this.WithProperty("create_base_policy", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? GlobalNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("global_network_id");
        set => this.WithProperty("global_network_id", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
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
    /// The edges attribute.
    /// </summary>
    public TerraformExpression Edges => this["edges"];

    /// <summary>
    /// The segments attribute.
    /// </summary>
    public TerraformExpression Segments => this["segments"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
