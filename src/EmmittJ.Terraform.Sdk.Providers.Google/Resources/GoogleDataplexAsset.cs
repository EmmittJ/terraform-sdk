using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dataplex_asset resource.
/// </summary>
public class GoogleDataplexAsset : TerraformResource
{
    public GoogleDataplexAsset(string name) : base("google_dataplex_asset", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("discovery_status");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("resource_status");
        this.DeclareOutput("security_status");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The zone for the resource
    /// </summary>
    public TerraformLiteralProperty<string>? DataplexZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dataplex_zone");
        set => this.WithProperty("dataplex_zone", value);
    }

    /// <summary>
    /// Optional. Description of the asset.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Optional. User friendly display name.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// Optional. User defined labels for the asset.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field `effective_labels` for all of the labels present on the resource.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The lake for the resource
    /// </summary>
    public TerraformLiteralProperty<string>? Lake
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lake");
        set => this.WithProperty("lake", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name of the asset.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Output only. The time when the asset was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Output only. Status of the discovery feature applied to data referenced by this asset.
    /// </summary>
    public TerraformExpression DiscoveryStatus => this["discovery_status"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Output only. Status of the resource referenced by this asset.
    /// </summary>
    public TerraformExpression ResourceStatus => this["resource_status"];

    /// <summary>
    /// Output only. Status of the security policy applied to resource referenced by this asset.
    /// </summary>
    public TerraformExpression SecurityStatus => this["security_status"];

    /// <summary>
    /// Output only. Current state of the asset. Possible values: STATE_UNSPECIFIED, ACTIVE, CREATING, DELETING, ACTION_REQUIRED
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Output only. System generated globally unique ID for the asset. This ID will be different if the asset is deleted and re-created with the same name.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Output only. The time when the asset was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
