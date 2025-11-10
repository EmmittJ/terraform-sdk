using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for asset in .
/// Nesting mode: set
/// </summary>
public class AwsDataexchangeRevisionAssetsAssetBlock : TerraformBlock
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string>? Arn
    {
        set => SetProperty("arn", value);
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformProperty<string>? CreatedAt
    {
        set => SetProperty("created_at", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformProperty<string>? UpdatedAt
    {
        set => SetProperty("updated_at", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDataexchangeRevisionAssetsTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_dataexchange_revision_assets resource.
/// </summary>
public class AwsDataexchangeRevisionAssets : TerraformResource
{
    public AwsDataexchangeRevisionAssets(string name) : base("aws_dataexchange_revision_assets", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("created_at");
        SetOutput("id");
        SetOutput("tags_all");
        SetOutput("updated_at");
        SetOutput("comment");
        SetOutput("data_set_id");
        SetOutput("finalized");
        SetOutput("force_destroy");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformProperty<string> Comment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("comment");
        set => SetProperty("comment", value);
    }

    /// <summary>
    /// The data_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSetId is required")]
    public required TerraformProperty<string> DataSetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_set_id");
        set => SetProperty("data_set_id", value);
    }

    /// <summary>
    /// The finalized attribute.
    /// </summary>
    public TerraformProperty<bool> Finalized
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("finalized");
        set => SetProperty("finalized", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> ForceDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_destroy");
        set => SetProperty("force_destroy", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for asset.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsDataexchangeRevisionAssetsAssetBlock>? Asset
    {
        set => SetProperty("asset", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDataexchangeRevisionAssetsTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformExpression UpdatedAt => this["updated_at"];

}
