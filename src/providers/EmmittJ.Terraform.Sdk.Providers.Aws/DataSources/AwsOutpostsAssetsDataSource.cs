using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_outposts_assets.
/// </summary>
public class AwsOutpostsAssetsDataSource : TerraformDataSource
{
    public AwsOutpostsAssetsDataSource(string name) : base("aws_outposts_assets", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("asset_ids");
        SetOutput("arn");
        SetOutput("host_id_filter");
        SetOutput("id");
        SetOutput("region");
        SetOutput("status_id_filter");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
    }

    /// <summary>
    /// The host_id_filter attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> HostIdFilter
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("host_id_filter");
        set => SetProperty("host_id_filter", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The status_id_filter attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> StatusIdFilter
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("status_id_filter");
        set => SetProperty("status_id_filter", value);
    }

    /// <summary>
    /// The asset_ids attribute.
    /// </summary>
    public TerraformExpression AssetIds => this["asset_ids"];

}
