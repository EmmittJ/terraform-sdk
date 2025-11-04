using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_location_tracker_associations.
/// </summary>
public class AwsLocationTrackerAssociationsDataSource : TerraformDataSource
{
    public AwsLocationTrackerAssociationsDataSource(string name) : base("aws_location_tracker_associations", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("consumer_arns");
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
    /// The tracker_name attribute.
    /// </summary>
    public string? TrackerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tracker_name")?.Value;
        set => this.WithProperty("tracker_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The consumer_arns attribute.
    /// </summary>
    public TerraformExpression ConsumerArns => this["consumer_arns"];

}
