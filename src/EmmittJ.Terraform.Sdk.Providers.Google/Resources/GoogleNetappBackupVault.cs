using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_netapp_backup_vault resource.
/// </summary>
public class GoogleNetappBackupVault : TerraformResource
{
    public GoogleNetappBackupVault(string name) : base("google_netapp_backup_vault", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("destination_backup_vault");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("source_backup_vault");
        this.DeclareOutput("source_region");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// Region in which backup is stored.
    /// </summary>
    public TerraformProperty<string>? BackupRegion
    {
        get => GetProperty<TerraformProperty<string>>("backup_region");
        set => this.WithProperty("backup_region", value);
    }

    /// <summary>
    /// Type of the backup vault to be created. Default is IN_REGION. Possible values: [&amp;quot;BACKUP_VAULT_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;IN_REGION&amp;quot;, &amp;quot;CROSS_REGION&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? BackupVaultType
    {
        get => GetProperty<TerraformProperty<string>>("backup_vault_type");
        set => this.WithProperty("backup_vault_type", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Location (region) of the backup vault.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The resource name of the backup vault. Needs to be unique per location.
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
    /// Create time of the backup vault. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Name of the Backup vault created in backup region.
    /// </summary>
    public TerraformExpression DestinationBackupVault => this["destination_backup_vault"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Name of the Backup vault created in source region.
    /// </summary>
    public TerraformExpression SourceBackupVault => this["source_backup_vault"];

    /// <summary>
    /// Region in which the backup vault is created.
    /// </summary>
    public TerraformExpression SourceRegion => this["source_region"];

    /// <summary>
    /// The state of the Backup Vault.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
