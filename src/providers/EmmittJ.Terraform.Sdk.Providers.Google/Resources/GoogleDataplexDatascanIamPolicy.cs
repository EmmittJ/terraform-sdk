using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dataplex_datascan_iam_policy resource.
/// </summary>
public class GoogleDataplexDatascanIamPolicy : TerraformResource
{
    public GoogleDataplexDatascanIamPolicy(string name) : base("google_dataplex_datascan_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("etag");
        SetOutput("data_scan_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("policy_data");
        SetOutput("project");
    }

    /// <summary>
    /// The data_scan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataScanId is required")]
    public required TerraformProperty<string> DataScanId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_scan_id");
        set => SetProperty("data_scan_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyData is required")]
    public required TerraformProperty<string> PolicyData
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_data");
        set => SetProperty("policy_data", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
