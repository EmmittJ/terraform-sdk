using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_netapp_volume_quota_rule resource.
/// </summary>
public class GoogleNetappVolumeQuotaRule : TerraformResource
{
    public GoogleNetappVolumeQuotaRule(string name) : base("google_netapp_volume_quota_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("state");
        this.DeclareOutput("state_details");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// Description for the quota rule.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The maximum allowed capacity in MiB.
    /// </summary>
    public TerraformProperty<double>? DiskLimitMib
    {
        get => GetProperty<TerraformProperty<double>>("disk_limit_mib");
        set => this.WithProperty("disk_limit_mib", value);
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
    /// Labels as key value pairs of the quota rule. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMapProperty<string>? Labels
    {
        get => GetProperty<TerraformMapProperty<string>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Loction of the quotaRule. QuotaRules are child resources of volumes and live in the same location.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The resource name of the quotaRule.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The quota rule applies to the specified user or group.
    /// Valid targets for volumes with NFS protocol enabled:
    ///   - UNIX UID for individual user quota
    ///   - UNIX GID for individual group quota
    /// Valid targets for volumes with SMB protocol enabled:
    ///   - Windows SID for individual user quota
    /// Leave empty for default quotas
    /// </summary>
    public TerraformProperty<string>? Target
    {
        get => GetProperty<TerraformProperty<string>>("target");
        set => this.WithProperty("target", value);
    }

    /// <summary>
    /// Types of Quota Rule. Possible values: [&amp;quot;INDIVIDUAL_USER_QUOTA&amp;quot;, &amp;quot;INDIVIDUAL_GROUP_QUOTA&amp;quot;, &amp;quot;DEFAULT_USER_QUOTA&amp;quot;, &amp;quot;DEFAULT_GROUP_QUOTA&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Name of the volume to create the quotaRule in.
    /// </summary>
    public TerraformProperty<string>? VolumeName
    {
        get => GetProperty<TerraformProperty<string>>("volume_name");
        set => this.WithProperty("volume_name", value);
    }

    /// <summary>
    /// Create time of the quota rule. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The state of the quota rule. Possible Values : [STATE_UNSPECIFIED, CREATING, UPDATING, READY, DELETING, ERROR]
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// State details of the quota rule
    /// </summary>
    public TerraformExpression StateDetails => this["state_details"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
