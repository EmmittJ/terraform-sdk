using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_kms_ekm_connection resource.
/// </summary>
public class GoogleKmsEkmConnection : TerraformResource
{
    public GoogleKmsEkmConnection(string name) : base("google_kms_ekm_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
    }

    /// <summary>
    /// Optional. Identifies the EKM Crypto Space that this EkmConnection maps to. Note: This field is required if KeyManagementMode is CLOUD_KMS.
    /// </summary>
    public string? CryptoSpacePath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("crypto_space_path")?.Value;
        set => this.WithProperty("crypto_space_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional. Etag of the currently stored EkmConnection.
    /// </summary>
    public string? Etag
    {
        get => GetProperty<TerraformLiteralProperty<string>>("etag")?.Value;
        set => this.WithProperty("etag", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Optional. Describes who can perform control plane operations on the EKM. If unset, this defaults to MANUAL Default value: &amp;quot;MANUAL&amp;quot; Possible values: [&amp;quot;MANUAL&amp;quot;, &amp;quot;CLOUD_KMS&amp;quot;]
    /// </summary>
    public string? KeyManagementMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_management_mode")?.Value;
        set => this.WithProperty("key_management_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location for the EkmConnection.
    /// A full list of valid locations can be found by running &#39;gcloud kms locations list&#39;.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource name for the EkmConnection.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Output only. The time at which the EkmConnection was created.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

}
