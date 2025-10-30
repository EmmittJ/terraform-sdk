namespace EmmittJ.Terraform.Sdk.Tests;

public class DependencyGraphTests
{
    [Fact]
    public void AddConstruct_AddsToGraph()
    {
        var graph = new DependencyGraph();
        var vpc = new TerraformResource("aws_vpc", "main");

        graph.AddConstruct(vpc);

        Assert.Contains(vpc, graph.Constructs);
    }

    [Fact]
    public void AddDependency_RecordsDependsOnRelationship()
    {
        var graph = new DependencyGraph();
        var vpc = new TerraformResource("aws_vpc", "main");
        var subnet = new TerraformResource("aws_subnet", "app");

        // subnet depends_on vpc
        graph.AddDependency(subnet, vpc);

        var deps = graph.GetDependsOn(subnet);
        Assert.Contains(vpc, deps);
    }

    [Fact]
    public void GetDependents_ReturnsReverseRelationship()
    {
        var graph = new DependencyGraph();
        var vpc = new TerraformResource("aws_vpc", "main");
        var subnet = new TerraformResource("aws_subnet", "app");

        // subnet depends_on vpc
        graph.AddDependency(subnet, vpc);

        var dependents = graph.GetDependents(vpc);
        Assert.Contains(subnet, dependents);
    }

    [Fact]
    public void HasCycles_ReturnsFalse_WhenNoCycles()
    {
        var graph = new DependencyGraph();
        var vpc = new TerraformResource("aws_vpc", "main");
        var subnet = new TerraformResource("aws_subnet", "app");
        var instance = new TerraformResource("aws_instance", "web");

        // Linear: instance -> subnet -> vpc
        graph.AddDependency(instance, subnet);
        graph.AddDependency(subnet, vpc);

        Assert.False(graph.HasCycles());
    }

    [Fact]
    public void HasCycles_ReturnsTrue_WhenCycleExists()
    {
        var graph = new DependencyGraph();
        var a = new TerraformResource("aws_vpc", "a");
        var b = new TerraformResource("aws_vpc", "b");
        var c = new TerraformResource("aws_vpc", "c");

        // Create cycle: a -> b -> c -> a
        graph.AddDependency(a, b);
        graph.AddDependency(b, c);
        graph.AddDependency(c, a);

        Assert.True(graph.HasCycles());
    }

    [Fact]
    public void FindCycles_ReturnsCycle()
    {
        var graph = new DependencyGraph();
        var a = new TerraformResource("aws_vpc", "a");
        var b = new TerraformResource("aws_vpc", "b");
        var c = new TerraformResource("aws_vpc", "c");

        // Create cycle: a -> b -> c -> a
        graph.AddDependency(a, b);
        graph.AddDependency(b, c);
        graph.AddDependency(c, a);

        var cycles = graph.FindCycles();
        Assert.NotEmpty(cycles);
        var cycle = cycles.First();
        Assert.Contains(a, cycle);
        Assert.Contains(b, cycle);
        Assert.Contains(c, cycle);
    }

    [Fact]
    public void TopologicalSort_ReturnsCorrectOrder()
    {
        var graph = new DependencyGraph();
        var vpc = new TerraformResource("aws_vpc", "main");
        var subnet = new TerraformResource("aws_subnet", "app");
        var instance = new TerraformResource("aws_instance", "web");

        // instance depends_on subnet depends_on vpc
        graph.AddDependency(instance, subnet);
        graph.AddDependency(subnet, vpc);

        var sorted = graph.TopologicalSort();

        // VPC should come before subnet, subnet before instance
        var vpcIndex = sorted.ToList().IndexOf(vpc);
        var subnetIndex = sorted.ToList().IndexOf(subnet);
        var instanceIndex = sorted.ToList().IndexOf(instance);

        Assert.True(vpcIndex < subnetIndex);
        Assert.True(subnetIndex < instanceIndex);
    }

    [Fact]
    public void TopologicalSort_ThrowsOnCycle()
    {
        var graph = new DependencyGraph();
        var a = new TerraformResource("aws_vpc", "a");
        var b = new TerraformResource("aws_vpc", "b");

        // Create cycle: a -> b -> a
        graph.AddDependency(a, b);
        graph.AddDependency(b, a);

        Assert.Throws<TerraformConfigurationException>(() => graph.TopologicalSort());
    }

    [Fact]
    public void GetDescription_ReturnsHumanReadableFormat()
    {
        var graph = new DependencyGraph();
        var vpc = new TerraformResource("aws_vpc", "main");
        var subnet = new TerraformResource("aws_subnet", "app");

        graph.AddDependency(subnet, vpc);

        var description = graph.GetDescription();

        Assert.Contains("Dependency Graph", description);
        Assert.Contains("depends_on", description);
    }
}
