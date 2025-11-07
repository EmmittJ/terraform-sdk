using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apigee_sharedflow resource.
/// </summary>
public class GoogleApigeeSharedflow : TerraformResource
{
    public GoogleApigeeSharedflow(string name) : base("google_apigee_sharedflow", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("latest_revision_id");
        this.DeclareOutput("md5hash");
        this.DeclareOutput("meta_data");
        this.DeclareOutput("revision");
    }

    /// <summary>
    /// Path to the config zip bundle
    /// </summary>
    public TerraformLiteralProperty<string>? ConfigBundle
    {
        get => GetProperty<TerraformLiteralProperty<string>>("config_bundle");
        set => this.WithProperty("config_bundle", value);
    }

    /// <summary>
    /// A hash of local config bundle in string, user needs to use a Terraform Hash function of their choice. A change in hash will trigger an update.
    /// </summary>
    public TerraformLiteralProperty<string>? DetectMd5hash
    {
        get => GetProperty<TerraformLiteralProperty<string>>("detect_md5hash");
        set => this.WithProperty("detect_md5hash", value);
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
    /// The ID of the shared flow.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The Apigee Organization name associated with the Apigee instance.
    /// </summary>
    public TerraformLiteralProperty<string>? OrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// The id of the most recently created revision for this shared flow.
    /// </summary>
    public TerraformExpression LatestRevisionId => this["latest_revision_id"];

    /// <summary>
    /// Base 64 MD5 hash of the uploaded config bundle.
    /// </summary>
    public TerraformExpression Md5hash => this["md5hash"];

    /// <summary>
    /// Metadata describing the shared flow.
    /// </summary>
    public TerraformExpression MetaData => this["meta_data"];

    /// <summary>
    /// A list of revisions of this shared flow.
    /// </summary>
    public TerraformExpression Revision => this["revision"];

}
