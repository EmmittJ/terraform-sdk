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
    public string? BasePolicyDocument
    {
        get => GetProperty<TerraformLiteralProperty<string>>("base_policy_document")?.Value;
        set => this.WithProperty("base_policy_document", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The base_policy_region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? BasePolicyRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("base_policy_region")?.Value;
        set => this.WithProperty("base_policy_region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The base_policy_regions attribute.
    /// </summary>
    public HashSet<string>? BasePolicyRegions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("base_policy_regions")?.Value;
        set => this.WithProperty("base_policy_regions", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The create_base_policy attribute.
    /// </summary>
    public bool? CreateBasePolicy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("create_base_policy")?.Value;
        set => this.WithProperty("create_base_policy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    public string? GlobalNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("global_network_id")?.Value;
        set => this.WithProperty("global_network_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
