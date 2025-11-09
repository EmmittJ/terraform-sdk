using EmmittJ.Terraform.Sdk;

namespace Examples;

/// <summary>
/// Example of a generated AWS EC2 Instance resource showing TerraformMapProperty usage.
/// This demonstrates how the Tags property would be generated with the new map property type.
/// </summary>
public class AwsInstance : TerraformResource
{
    public AwsInstance(string name) : base("aws_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("arn");
        this.DeclareOutput("public_ip");
        this.DeclareOutput("private_ip");
    }

    /// <summary>
    /// The AMI to use for the instance.
    /// </summary>
    public TerraformProperty<string>? Ami
    {
        get => GetProperty<TerraformProperty<string>>("ami");
        set => this.WithProperty("ami", value);
    }

    /// <summary>
    /// The instance type to use for the instance (e.g., t2.micro, m5.large).
    /// </summary>
    public TerraformProperty<string>? InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
    }

    /// <summary>
    /// Map of tags to assign to the resource.
    /// Now properly typed as TerraformMapProperty instead of generic TerraformProperty!
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The instance ID.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The ARN of the instance.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The public IP address assigned to the instance.
    /// </summary>
    public TerraformExpression PublicIp => this["public_ip"];

    /// <summary>
    /// The private IP address assigned to the instance.
    /// </summary>
    public TerraformExpression PrivateIp => this["private_ip"];
}

// Usage example
public static class UsageExample
{
    public static void CreateInstance()
    {
        var stack = new TerraformStack();

        // Create an EC2 instance with tags using the new TerraformMapProperty
        var instance = new AwsInstance("web_server")
        {
            Ami = "ami-0c55b159cbfafe1f0",
            InstanceType = "t2.micro",
            // Now you can assign dictionaries directly with proper type safety!
            Tags = new Dictionary<string, string>
            {
                ["Name"] = "WebServer",
                ["Environment"] = "Production",
                ["ManagedBy"] = "Terraform",
                ["CostCenter"] = "Engineering"
            }
        };

        stack.Add(instance);

        // Output the Terraform configuration
        var hcl = stack.ToHcl();
        Console.WriteLine(hcl);
    }
}
