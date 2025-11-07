using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dataplex_asset_iam_policy resource.
/// </summary>
public class GoogleDataplexAssetIamPolicy : TerraformResource
{
    public GoogleDataplexAssetIamPolicy(string name) : base("google_dataplex_asset_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
    }

    /// <summary>
    /// The asset attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Asset
    {
        get => GetProperty<TerraformLiteralProperty<string>>("asset");
        set => this.WithProperty("asset", value);
    }

    /// <summary>
    /// The dataplex_zone attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DataplexZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dataplex_zone");
        set => this.WithProperty("dataplex_zone", value);
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
    /// The lake attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Lake
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lake");
        set => this.WithProperty("lake", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_data");
        set => this.WithProperty("policy_data", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
