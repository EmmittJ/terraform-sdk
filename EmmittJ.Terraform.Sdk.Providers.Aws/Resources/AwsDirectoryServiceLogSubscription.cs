using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_directory_service_log_subscription resource.
/// </summary>
public class AwsDirectoryServiceLogSubscription : TerraformResource
{
    public AwsDirectoryServiceLogSubscription(string name) : base("aws_directory_service_log_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public string? DirectoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("directory_id")?.Value;
        set => this.WithProperty("directory_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The log_group_name attribute.
    /// </summary>
    public string? LogGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_group_name")?.Value;
        set => this.WithProperty("log_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
